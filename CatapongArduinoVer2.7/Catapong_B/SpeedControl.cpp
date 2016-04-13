/*
 * SpeedControl.cpp
 *
 *  Created on: Apr 25, 2015
 *      Author: Fisher
 */

#include "SpeedControl.h"
#include "pins_arduino.h"
#include "Arduino.h"
#include ".\Hardware\Hardware.h"

signed int targetSpeedPD;
//signed char flg_DCMChange;

void InitSpeedControl(void)
{
	//Initialize timer 2
//	TCCR2A = (1<<COM2A1)|(0<<COM2A0);
//	TCCR2B = (1<<CS22)|(1<<CS21)|(0<<CS20);
//	OCR2A = 62;


//	TIMSK2 = 1<<OCIE2A;//interrupter

}

void TurnOnSpeedControl(signed int targetSpeed)
{
	targetSpeedPD = targetSpeed;
	Motor_EnBridge(1);
	flg_EnablePDControl = 1;
//	TIMSK2 = 1<<OCIE2A;//enable interrupter
	Encoder_Clear();//clear Encoder data
}

void TurnOffSpeedControl(void)
{
	Motor_EnBridge(0);
	flg_EnablePDControl = 0;
//	TIMSK2 = 0;//diable interrupter
//	Encoder_Clear();//clear Encoder data
}

void SetSpeed(signed int targetSpeed)
{
	targetSpeedPD = targetSpeed;
}

signed int currentSpeed;
float pdSpeed;
#define pram  0.05

void PD(void)
{
	signed int diff;
	currentSpeed = Encoder_Read();
	Encoder_Clear();

	diff = targetSpeedPD - currentSpeed;
	pdSpeed += (pram * (float)diff);

	if(pdSpeed > 350) pdSpeed = 350;
	if(pdSpeed < -100) pdSpeed = -100;
	Motor_SetPower((int)pdSpeed);
}
#define ABS(x)	((x)<0?(-(x)):(x))


unsigned int idx_speedState = 0;
unsigned char flg_EnablePDControl = 0;
void InterruptEvent_SpeedControl(void)
{
	if(flg_EnablePDControl == 1){
//		Serial.print("A");
		PD();
		speedState[idx_speedState] = ABS(targetSpeedPD- currentSpeed);
		idx_speedState ++;
		if(idx_speedState > 200)idx_speedState = 0;
	}
}

signed int speedState[200];

unsigned char SpeedControl_CheckSpeed(void)
{
	unsigned char i;
	unsigned int sum = 0;
	for(i=0;i<200;i++)
	{
		sum += speedState[i];
	}

//	Serial.print("(");
//	Serial.print(sum);
//	Serial.print(")");

	if(sum < THRD_Steady)return STATE_STUDY;
	else return STATE_ADJUST;
}















