/*
 * IRSensor.h
 *
 *  Created on: Apr 28, 2015
 *      Author: Fisher
 */

#ifndef IRSENSOR_H_
#define IRSENSOR_H_

void IRSensor_InitDevice(void);
void IRSensor_EnIN0(unsigned char En);
void IRSensor_InterruptEvent(void);
unsigned char IRSensor_Read(unsigned char deviceNum);


#endif /* IRSENSOR_H_ */
