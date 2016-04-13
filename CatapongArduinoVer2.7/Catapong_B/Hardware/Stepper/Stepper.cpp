/*
 * Stepper.cpp
 *
 *  Created on: Apr 25, 2015
 *      Author: Fisher
 */

#include "Stepper.h"
#include  "Arduino.h"

#define PORT 	PORTC
#define DDR		DDRC
#define BitA1	0
#define BitA2	1
#define BitB1	2
#define BitB2	3

#define EnPORT 	PORTD
#define EnDDR	DDRD
#define BitEn	5

#define PinIR	2

#define SetSign(bit,x) ((x)==0?(PORT &= ~(1<<bit)):(PORT |= 1<<bit))

//#define PhaseA	0
//#define PhaseB	1
//#define Positive	1
//#define Negative	0

#define TRUE 	1
#define FALSE	0

#define DONE 	1
#define FAIL	0

#define LEFT 	-1
#define RIGHT	1

unsigned int  	Ctr_waiting;
unsigned long  	Ctr_step = 0; //steps to go, discounting
unsigned int	waitTime = 10;
signed char 	direction = RIGHT;


void Stepper_InitDevice(void)
{
	DDR |= (1<<BitA1)|(1<<BitA2)|(1<<BitB1)|(1<<BitB2);//set pins output
	EnDDR |= (1<<BitEn);



	Stepper_EnDrive(FALSE);
}

void Stepper_EnDrive(unsigned char En)
{
	if(En == TRUE)EnPORT |= 1<<BitEn;
	else EnPORT &= ~(1<<BitEn);
}


signed char stepIdx = 0;
void Stepper_GoSingleStep(signed char dir)
{
	stepIdx += dir;
	if(stepIdx < 0)stepIdx = 3;
	else if(stepIdx > 3)stepIdx = 0;

	switch(stepIdx){
		case 0:
			SetSign(BitA1,1);
			SetSign(BitA2,0);
			SetSign(BitB1,0);
			SetSign(BitB2,1);
			break;
		case 1:
			SetSign(BitA1,1);
			SetSign(BitA2,0);
			SetSign(BitB1,1);
			SetSign(BitB2,0);
			break;
		case 2:
			SetSign(BitA1,0);
			SetSign(BitA2,1);
			SetSign(BitB1,1);
			SetSign(BitB2,0);
			break;
		case 3:
			SetSign(BitA1,0);
			SetSign(BitA2,1);
			SetSign(BitB1,0);
			SetSign(BitB2,1);
			break;
	}
}

unsigned char Stepper_Move(signed char dir, unsigned int steps, unsigned int speed)
{
//	Serial.print("Start ");
	if(Ctr_step > 0)return FAIL;//if stepper is still moving, do not set new move task
	else{
		if(speed>15)speed = 15;
		waitTime = 20 - speed;

		Stepper_EnDrive(TRUE);
		direction = dir;
		Ctr_step = 8*((unsigned long)steps);
		Ctr_waiting = waitTime;//reset wait-time
	}

	return DONE;
}

void Stepper_OnPos0(void)
{
	Ctr_step = 0;
	Stepper_EnDrive(FALSE);
}


//run this interrupt event function at 10khz
void Stepper_InterruptEvent(void)
{
	if(digitalRead(PinIR) == 0){ //if IR sensor is covered
		waitTime = 20 - 6;
		Stepper_EnDrive(TRUE);
		direction = 1;
		Ctr_step = 8 * 10;
	}



	if(Ctr_step > 0)//if stepper is on working status
	{
		if(Ctr_waiting == 0)
		{
			Ctr_waiting = waitTime;//reset wait-time
			Stepper_GoSingleStep(direction);//go a single step
			Ctr_step --;
		}
		else{
			Ctr_waiting --;
		}
	}
	else
	{
		Stepper_EnDrive(FALSE); //move ends, turn off stepper driver
	}

}

unsigned char Stepper_CheckStepper(void)
{
	if(Ctr_step > 0)return StepperIsWorking;
	else return StepperIsWaiting;
}













