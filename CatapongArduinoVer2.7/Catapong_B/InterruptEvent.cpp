/*
 * InterruptEvent.cpp
 *
 *  Created on: Apr 25, 2015
 *      Author: Fisher
 */

#include "InterruptEvent.h"
#include "Catapong_B.h"
#include "Wire.h"
#include "SpeedControl.h"
#include ".\Hardware\Hardware.h"



unsigned char test = 0;
unsigned int counter =0;
unsigned int delayParameter = 0;
//unsigned long testCounter=0;

ISR(TIMER2_COMPA_vect){ //10kHz timer
	TCNT2 = 0; //clear timer

	counter ++;

	Stepper_InterruptEvent();

	if(counter%50 == 0)//every 5 ms
	{
		InterruptEvent_SpeedControl();
//		Serial.print(currentSpeed);
	}


	if(counter%10000 == 0)
	{

		counter=0; //every 1000 ms reset counter
	}





}
//unsigned int c;
//ISR(TIMER1_OVF_vect){
//	c ++;
//
//	if(c%500 == 6) PORTB &= ~(1<<PORTB0);
//
//	if(c%1000 == 0){ //every 20ms
//
//		PORTB |= 1<<PORTB0;
////		if(flg_PDControl == 1)
////		{
////			Event_SpeedControl(targetSpeed);//PD speed control
////		}
////		currentSpeed = Encoder_Read();
////		Encoder_Clear();
//		if(c%20000 == 0)
//		{
//
//			c=0;
////			flg_test = 1;
//		}
//	}
//}
