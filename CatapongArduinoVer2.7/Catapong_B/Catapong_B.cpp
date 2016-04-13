// Do not remove the include below
#include "Catapong_B.h"

//import public library
#include "Wire.h"

//import private library
#include ".\Hardware\Hardware.h"

//import project header
#include "InterruptEvent.h"
#include "PublicDef.h"
#include "SpeedControl.h"
#include "I2cCMD.h"


/* Timer arrangement
 * Timer 0	- Encoder pulse counting
 * Timer 1 	- DC motor PWM (dual mode)
 * Timer 2	- Timer interrupt for PD speed control
 */

#define CMD_SPIN 	1
#define CMD_STOP	2

#define ABS(x)	((x)<0?(-(x)):(x))

unsigned char* ADDR_varReq = 0;

unsigned char flg_launch = 0;
unsigned char flg_arrive = 0;

unsigned char IIC_cmd = 0;
unsigned int IIC_data1 =0;
unsigned int IIC_data2 =0;
unsigned int IIC_data3 =0;

unsigned char flg_CMDin = 0;
void OnIICReceive(int howMany)
{
//	char c;
	flg_CMDin = 1;

	while (6 < Wire.available()) // loop through all but the last
	{
		IIC_cmd = Wire.read();
	}
	IIC_data1 = Wire.read();
	IIC_data1 |= ((unsigned int)Wire.read())<<8;
	IIC_data2 = Wire.read();
	IIC_data2 |= ((unsigned int)Wire.read())<<8;
	IIC_data3 = Wire.read();
	IIC_data3 |= ((unsigned int)Wire.read())<<8;
}



void OnIICRequest(void)
{
//	Serial.print("(");
//	Serial.print(*ADDR_varReq);
//	Serial.print(")");

	Wire.write(char(*ADDR_varReq));
}

void IRSensor_StepperPos0(void){
	if(digitalRead(2) == 1)
	{
		Stepper_OnPos0();//STOP STEPPER
	}
}


void setup()
{
	noInterrupts();

	/***** hardware *****/
	//	init Serial
	Serial.begin(9600);

	//	init I2C
	Wire.begin(2);
	Wire.onRequest(OnIICRequest); // register event
	Wire.onReceive(OnIICReceive); // register event

	//	init Encoder
	Encoder_InitDevice();
	//	init DC motor Driver
	Motor_InitDevice(); //set PWM: freq = 10KHz
	//	init DC stepper motor Driver
	Stepper_InitDevice();

	//setup a 10kHz timer on timer2
	TCCR2A = (1<<COM2A1)|(0<<COM2A0);
	TCCR2B = (0<<CS22)|(1<<CS21)|(0<<CS20);
	OCR2A = 195;
	TIMSK2 = 1<<OCIE2A; //interrupter;//enable interrupter

	//set D2 as a external interrupt
	pinMode(2,   INPUT);
	attachInterrupt(0, IRSensor_StepperPos0, FALLING );


	Displayer_InitDevice();
	Displayer_DisplayString("hello!",0,0,0);

//	Display_testGPIO(1);
//	Serial.print("ok");

	/***** software *****/
	//	init PD speed-control
	InitSpeedControl();
	TurnOffSpeedControl();


//	Serial.print("start!");
//	Serial.print("\n");

	interrupts();
	//testing
//	flg_CMDin = 1;
//	IIC_data1 = -1;
//	IIC_data2 = 500;
//	IIC_data3 = 12;
//	IIC_cmd = CMD_MoveSlider;
//	Motor_SetPower(100);
//	Motor_EnBridge(1);
//	TurnOnSpeedControl(50);
//	Stepper_Move(-1,500,9);
}


void loop()
{

	if(flg_CMDin == 1)
	{
		flg_CMDin = 0; //clear the flag
		Serial.print(IIC_cmd);Serial.print(":"); //testing
		switch(IIC_cmd)
		{
		case CMD_MoveSlider:
			while(Stepper_CheckStepper() == StepperIsWorking);
			Stepper_Move((char)IIC_data1, (unsigned int)IIC_data2, (unsigned int)IIC_data3);

			Serial.print((char)IIC_data1);Serial.print(",");//testing
			Serial.print((unsigned int)IIC_data2);Serial.print(",");//testing
			Serial.print((unsigned int)IIC_data3);Serial.print("\n");//testing
			break;

		case CMD_SpinLaunch:
			TurnOnSpeedControl((signed int)IIC_data1);
			Serial.print((signed int)IIC_data1);Serial.print("\n");//testing
			break;

		case CMD_SpinSlow:
			TurnOffSpeedControl();
			Motor_SetPower((signed int)IIC_data1);
			Motor_EnBridge(1);
			Serial.print((signed int)IIC_data1);Serial.print("\n");//testing
			break;
		case CMD_StopSpin:
			TurnOffSpeedControl();
			Motor_SetPower(0);
			Motor_EnBridge(0);
			break;
		case CMD_RequestFlag:
			Serial.print(IIC_data1);Serial.print("\n");//testing
			switch(IIC_data1)
			{
			case REQ_NONE:
				ADDR_varReq = 0;
				break;
			case REQ_Launch:
				ADDR_varReq = &flg_launch;
				flg_launch=0;
				break;
			case REQ_Arrive:
				ADDR_varReq = &flg_arrive;
				flg_arrive = 0;
				break;
			}
			break;
		}
	}

	//checking status
	if(ADDR_varReq == &flg_launch)	flg_launch = SpeedControl_CheckSpeed();
	if(ADDR_varReq == &flg_arrive)	flg_arrive = Stepper_CheckStepper();

}
