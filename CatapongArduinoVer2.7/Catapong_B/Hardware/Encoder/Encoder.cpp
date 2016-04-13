/*
 * Encoder.cpp
 *
 *  Created on: Apr 23, 2015
 *      Author: Fisher
 */

#include "Encoder.h"
#include "pins_arduino.h"
#include  "Arduino.h"

//#define PORT 	PORTD
#define DDR 	PORTD
#define BIT		PORTD4


void Encoder_Start(void){
	TCCR0B |= B00000111;//select external clock input T0 rise-edge
}


void Encoder_InitDevice(void)
{
	DDR 	&=  ~(1<<BIT);
	Encoder_Start();
//	TCCR1A
//	OCR1AL = 0xFF;
//	OCR1AH = 0xFF;

	TCNT0 = 0;//clear counter
}

unsigned int Encoder_Read(void)
{
	return TCNT0;
}

void Encoder_Clear(void)
{
	TCNT0 = 0;//clear counter
}
