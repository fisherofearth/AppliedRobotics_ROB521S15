/*
 * CPServo.cpp
 *
 *  Created on: Apr 26, 2015
 *      Author: Fisher
 */

#include "CPServo.h"
#include "pins_arduino.h"
#include "Servo.h"
#include  "Arduino.h"

Servo servoLoad1;
Servo servoLoad2;
Servo servoLoad3;
Servo servoSP;
Servo servoDef;

void CPServo_InitDevice(void)
{

	servoLoad1.attach(8);
	Servo_ClampOff();

	servoLoad2.attach(9);
	Servo_KeepBalls();

	servoLoad3.attach(10);
	Servo_CloseTrigger();

	servoSP.attach(11);
	Servo_StopPin_BACK();

	servoDef.attach(12);
	Servo_SwatterBack();

}

void CPServo_SetPos(char servoNum, int pos)
{
	switch(servoNum)
	{
	case 0:
		pos = map(pos, 0, 1023, 0, 270);
		servoLoad1.write(pos);
		break;
	case 1:
		pos = map(pos, 0, 1023, 0, 180);
		servoLoad2.write(pos);
		break;
	case 2:
		pos = map(pos, 0, 1023, 0, 180);
		servoLoad3.write(pos);
		break;
	case 3:
		pos = map(pos, 0, 1023, 0, 180);
		servoSP.write(pos);
		break;
	case 4:
		pos = map(pos, 0, 1023, 0, 180);
		servoDef.write(pos);
		break;
	}
}




