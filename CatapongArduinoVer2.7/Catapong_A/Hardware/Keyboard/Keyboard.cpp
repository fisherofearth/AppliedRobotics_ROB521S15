/*
 * Keyboard.cpp
 *
 *  Created on: Apr 26, 2015
 *      Author: Fisher
 */

#include "Keyboard.h"
#include "pins_arduino.h"
#include  "Arduino.h"

#define PORT	PORTB
#define DDR		DDRB

#define PIN_SWA	12
#define PIN_SWB 13

void Keyboard_InitDevice(void)
{
	pinMode(PIN_SWA,   INPUT);
	pinMode(PIN_SWB,   INPUT);
}


int Keyboard_Read(void)
{
	if(digitalRead(PIN_SWA) == 0)return 1;
	if(digitalRead(PIN_SWB) == 0)return 2;

	return 0;
}
