/*
 * IRSensor.cpp
 *
 *  Created on: Apr 28, 2015
 *      Author: Fisher
 */

#include "IRSensor.h"
#include "pins_arduino.h"
#include  "Arduino.h"

void IRSensor_InitDevice(void){
	IRSensor_EnIN0(0);
}


unsigned char IR_IN0 = 0;
void IRSensor_EnIN0(unsigned char En)
{
	if(En == 1){
		IR_IN0 = 0;
		attachInterrupt(0, IRSensor_InterruptEvent, FALLING );
	}
	else detachInterrupt(0);
}


void IRSensor_InterruptEvent(void)
{
	IR_IN0 = 1;
	delay(50);
}


unsigned char IRSensor_Read(unsigned char deviceNum)
{
	switch(deviceNum)
	{
	case 0:
		return IR_IN0;
		break;
	case 1:
		break;
	}
	return 0;
}
