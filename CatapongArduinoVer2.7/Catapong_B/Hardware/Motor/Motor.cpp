/*
 * Motor.cpp
 *
 *  Created on: Apr 23, 2015
 *      Author: Fisher
 */

#include "Motor.h"
#include "pins_arduino.h"
#include  "Arduino.h"


#define EnBit 	PORTB0 //pin - enable H-bridge
#define EnPORT 	PORTB
#define EnDDR	DDRB

#define PWMBit 	PORTB2 //pin - PWM output
#define PWMDDR	DDRB

#define TRUE	1
#define FALSE	0


void Motor_InitDevice(void)
{
	EnDDR 	|= 1 << EnBit; //set pin output
	PWMDDR 	|= 1 << PWMBit;//set pin output
	Motor_EnBridge(FALSE);//disable H-bridge

	//set PWM
	TCCR1A = (1<<WGM11)|(1<<WGM10)|(0<<COM1A1)|(1<<COM1A0)|(1<<COM1B1)|(0<<COM1B0);
	TCCR1B = (1<<WGM13)|(1<<WGM12)|(0<<CS12)|(0<<CS11)|(1<<CS10); //fast PWM mode ; frequence = 1khz

	OCR1A = (8000/10) - 1;///set frequency = 10kHz
	OCR1B =	399;//initially set duty time at 50%
//	TIMSK1 |= 1<<TOIE2;//interrupter
}

void Motor_SetPower(signed int P)
{
	OCR1B = 399 + P;
}

void Motor_EnBridge(unsigned char En)
{
	if(En == FALSE)EnPORT |= 1<<EnBit;
	else EnPORT &= ~(1<<EnBit);
}
