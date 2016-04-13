/*
 * CPServo.h
 *
 *  Created on: Apr 26, 2015
 *      Author: Fisher
 */

#ifndef CPSERVO_H_
#define CPSERVO_H_

void CPServo_InitDevice(void);
void CPServo_SetPos(char servoNum, int pos);

//servo270
#define Servo_ClampOff()		CPServo_SetPos(0, 100)//default 100
#define Servo_GrabBall()		CPServo_SetPos(0, 0)
#define Servo_OnLoad()			CPServo_SetPos(0, 625)
#define Servo_LoadBall()		CPServo_SetPos(0, 850)


//spinning-ball-holder
#define Servo_KeepBalls()		CPServo_SetPos(1, 1000)//default 1000
#define Servo_ReleaseBall(x)	CPServo_SetPos(1, (1000 -( (x+1)*300)))

//trigger-open-servo
#define Servo_OpenTrigger()		CPServo_SetPos(2, 250)
#define Servo_CloseTrigger()	CPServo_SetPos(2, 900)//default900

//stop pin
#define Servo_StopPin_OUT() 	CPServo_SetPos(3, 1000)
#define Servo_StopPin_BACK() 	CPServo_SetPos(3, 700)//default 700
#define Servo_StopPin_LOAD() 	CPServo_SetPos(3, 400)

//Defense
#define Servo_SwatterOut()		CPServo_SetPos(4, 1000)
#define Servo_SwatterBack()		CPServo_SetPos(4, 500)//default

#endif /* CPSERVO_H_ */
