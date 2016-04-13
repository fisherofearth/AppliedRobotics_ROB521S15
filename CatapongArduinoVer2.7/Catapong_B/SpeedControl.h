/*
 * SpeedControl.h
 *
 *  Created on: Apr 25, 2015
 *      Author: Fisher
 */

#ifndef SPEEDCONTROL_H_
#define SPEEDCONTROL_H_

void InitSpeedControl(void);
void InterruptEvent_SpeedControl(void);

void TurnOnSpeedControl(signed int targetSpeed);
void TurnOffSpeedControl(void);

void SetSpeed(signed int targetSpeed);
unsigned char SpeedControl_CheckSpeed(void);

extern signed char flg_DCMChange;
extern signed int currentSpeed;
extern signed int speedState[200];
extern unsigned char flg_EnablePDControl;

#define THRD_Steady 	200

#define STATE_ADJUST 	0
#define STATE_STUDY	 	1

#endif /* SPEEDCONTROL_H_ */
