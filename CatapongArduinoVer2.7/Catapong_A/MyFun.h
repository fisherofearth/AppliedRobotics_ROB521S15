/*
 * MyFun.h
 *
 *  Created on: Apr 24, 2015
 *      Author: Fisher
 */

#ifndef MYFUN_H_
#define MYFUN_H_

void IIC_InitDevice(void);
void IIC_SendCMD(
		unsigned char deviceNum,
		unsigned char CMD,
		signed int data1,
		signed int data2,
		signed int data3);
void IIC_Request(unsigned int deviceNum);
#endif /* MYFUN_H_ */
