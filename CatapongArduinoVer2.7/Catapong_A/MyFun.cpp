/*
 * MyFun.cpp
 *
 *  Created on: Apr 24, 2015
 *      Author: Fisher
 */


#include "MyFun.h"
#include "Wire.h"
#include "pins_arduino.h"

void IIC_InitDevice(void)
{
	Wire.begin();
}

void IIC_SendCMD(
		unsigned char deviceNum,
		unsigned char CMD,
		signed int data1,
		signed int data2,
		signed int data3)
{

	Wire.beginTransmission(deviceNum); // transmit to devic

	Wire.write(CMD);              // sends one byte
	Wire.write((unsigned char)(data1 & 0x00FF));              // sends one byte
	Wire.write((unsigned char)((data1 & 0xFF00) >> 8));              // sends one byte

	Wire.write((unsigned char)(data2 & 0x00FF));              // sends one byte
	Wire.write((unsigned char)((data2 & 0xFF00) >> 8));              // sends one byte

	Wire.write((unsigned char)(data3 & 0x00FF));              // sends one byte
	Wire.write((unsigned char)((data3 & 0xFF00) >> 8));              // sends one byte

//	Wire.write("EE");
	Wire.endTransmission();    // stop transmitting


}

void IIC_Request(unsigned int deviceNum)
{
	Wire.requestFrom(deviceNum, 1);
}
