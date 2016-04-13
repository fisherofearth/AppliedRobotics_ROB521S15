/*
 * Stepper.h
 *
 *  Created on: Apr 25, 2015
 *      Author: Fisher
 */

#ifndef HARDWARE_STEPPER_STEPPER_H_
#define HARDWARE_STEPPER_STEPPER_H_

void Stepper_InitDevice(void);
void Stepper_EnDrive(unsigned char En);
unsigned char Stepper_Move(signed char dir, unsigned int steps, unsigned int speed);//speed < 15
unsigned char Stepper_CheckStepper(void);
void Stepper_OnPos0(void);

void Stepper_InterruptEvent(void);

#define StepperIsWorking 	0
#define StepperIsWaiting	1

#endif /* HARDWARE_STEPPER_STEPPER_H_ */
