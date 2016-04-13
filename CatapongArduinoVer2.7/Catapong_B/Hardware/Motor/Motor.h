/*
 * Motor.h
 *
 *  Created on: Apr 23, 2015
 *      Author: Fisher
 */

#ifndef MOTOR_H_
#define MOTOR_H_s

void Motor_InitDevice(void);
void Motor_SetPower(signed int P);
void Motor_EnBridge(unsigned char En);


#define Motor_MID	0
#define Motor_MAX	399
#define Motor_MIN	-399

#endif /* MOTOR_H_ */
