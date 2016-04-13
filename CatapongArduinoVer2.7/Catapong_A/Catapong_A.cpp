// Do not remove the include below
#include "Catapong_A.h"


#include "pins_arduino.h"
#include ".\Hardware\Hardware.h"
#include "I2cCMD.h"

#include "MyFun.h"
#include "Wire.h"

#define CMD_NONE 	0
#define CMD_DEFANCE 1
#define CMD_LOAD	2
#define CMD_AIM 	3
#define CMD_ATTACK	4
#define CMD_RELBALL	5

signed int pp = 1;
signed int channalNum = 0;


unsigned int c = 0;
unsigned char flg_test = 0;
signed int targetSpeed = 100;
unsigned char flg_PDControl = 0;


unsigned char CMD = 0;
unsigned int  serialData1 = 0;
unsigned int  serialData2 = 0;

unsigned char flg_CMDin = 0;



void serialEvent() {
	long serialCMD;
	while (Serial.available()) {
		serialCMD = Serial.parseInt();
	}
	flg_CMDin = 1;
	CMD = (unsigned char)((serialCMD % 100) & 0xFF);
	serialData1 = (unsigned int)((serialCMD / 100) %10000);
	serialData2 = (unsigned int)(serialCMD / 1000000);

	Serial.print("OK");
	Serial.println(CMD);Serial.print(":");
	Serial.println(serialData1);Serial.print(", ");
	Serial.println(serialData2);Serial.print("\n");
}

void setup()
{
//	noInterrupts();
	Serial.begin(9600);
	IIC_InitDevice();//init as master
//	IIC_SendCMD(2,CMD_SpinSlow,150,0,0);//testing

//	Wire.begin();


//	Keyboard_InitDevice();
	CPServo_InitDevice();
	IRSensor_InitDevice();

	pinMode(7,OUTPUT);
	digitalWrite(7,HIGH);
	delay(200);
	digitalWrite(7,LOW);
	interrupts();
}

//unsigned char flg_launch = 0;
unsigned char ACTION=0;
void loop()
{

//		CPServo_SetPos(2, 500);
//		delay(5000);
//		CPServo_SetPos(2, 0);//default
//		delay(5000);


	unsigned char flg_wait = 0;
	if(flg_CMDin == 1){
		flg_CMDin = 0; //clear the flag
		ACTION = CMD;
	}

	switch(ACTION)
	{
	case CMD_NONE:
		break;
	case CMD_DEFANCE:
//		if(ReadSonar()==1){
//			Servo_SwatterOut();
//			delay(1000);
//			Servo_SwatterBack();
//		}

		break;
	case CMD_RELBALL:
		ACTION = CMD_NONE;
		Servo_ReleaseBall((signed int)serialData1);
		break;
	case CMD_LOAD:
		ACTION = CMD_NONE;



		Servo_ReleaseBall(channalNum);
		delay(2000);
		channalNum += pp;
		if(channalNum >= 1 || channalNum <=0) pp = pp*(-1);

		Servo_GrabBall();
		Servo_StopPin_BACK();
		delay(500);
		//spin slow (back) until IR
		IRSensor_EnIN0(1);
		IIC_SendCMD(2,CMD_SpinSlow,50,0,0);
		delay(200);
		while(IRSensor_Read(0) == 0);
		IIC_SendCMD(2,CMD_StopSpin,0,0,0);
		IRSensor_EnIN0(0);

		Servo_StopPin_LOAD();
		delay(200);
		IIC_SendCMD(2,CMD_SpinSlow,-40,0,0);//leave the load pin
		delay(300);



		delay(1500);
		Servo_OpenTrigger();
		Servo_OnLoad();
		delay(1500);
		Servo_LoadBall();
		delay(500);

		IIC_SendCMD(2,CMD_StopSpin,0,0,0);

		Servo_CloseTrigger();
		delay(500);


		IRSensor_EnIN0(1);
		IIC_SendCMD(2,CMD_SpinSlow,80,0,0);
		delay(200);
		while(IRSensor_Read(0) == 0);
		IRSensor_EnIN0(0);

		delay(200);
		IIC_SendCMD(2,CMD_StopSpin,0,0,0);


		Servo_StopPin_BACK();
		Servo_ClampOff();
		delay(200);

		break;
	case CMD_AIM:
		IIC_SendCMD(2, CMD_MoveSlider,
				(signed int)((serialData2) *2) -3,//direction
				(signed int)serialData1,//steps
				10);//speed


		ACTION = CMD_NONE;
		break;
	case CMD_ATTACK:

		Servo_StopPin_BACK();
		delay(500);

		//wait until the slider is arrived
		Serial.print("A");
		IIC_SendCMD(2,CMD_RequestFlag,REQ_Arrive,0,0);
		delay(200);
		flg_wait = 0;
		while(flg_wait == 0){
			delay(100);
			IIC_Request(2);
			delay(100);
			while(Wire.available()){
				flg_wait = Wire.read();
			}
		}
		Serial.print("B");

		IIC_SendCMD(2,CMD_SpinLaunch,(signed int)serialData1,0,0);
		delay(500);

		//wait until spinning speed is steady
		IIC_SendCMD(2,CMD_RequestFlag,REQ_Launch,0,0);
		flg_wait = 0;
		while(flg_wait != 1){
			delay(100);
			IIC_Request(2);
			delay(100);

			while(Wire.available()){
				flg_wait = (unsigned char)Wire.read();
//				Serial.print("(");
//				Serial.print(flg_wait);
//				Serial.print(")");
			}
		}

		Serial.print("C");
		//wait until IR sensor -> 1
		IRSensor_EnIN0(1);
		while(IRSensor_Read(0) == 0);
		IRSensor_EnIN0(0);

		Servo_StopPin_OUT();

		IIC_SendCMD(2,CMD_StopSpin,0,0,0);
		Serial.print("D");

//		delay(300);
//		Servo_StopPin_BACK();
		ACTION = CMD_NONE;
		break;
	}


}





















