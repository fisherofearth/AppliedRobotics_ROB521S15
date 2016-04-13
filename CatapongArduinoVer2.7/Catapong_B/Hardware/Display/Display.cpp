/*
 * Display.cpp
 *
 *  Created on: Apr 23, 2015
 *      Author: Fisher
 */

/*
 * Displayer.c
 *
 *  Created on: Jun 20, 2013
 *      Author: Fisher
 */


/* Including shared modules, which are used for whole project */


#include "Display.h"
#include "ASSIC.h"
#include <stdio.h>
#include "pins_arduino.h"
#include  "Arduino.h"
//Configuration---------------------------------------------------------------------------


#define MASK_PORT1 	PORTB
#define MASK_DDR1 	DDRB
#define MASK_RST    3
#define MASK_SDA    4
#define MASK_SCL    5

#define MASK_PORT2 	PORTD
#define MASK_DDR2 	DDRD
#define MASK_DC	    6
#define MASK_CS	    7


#define setBit1(x)	MASK_PORT1 |= 0x01 << x
#define clrBit1(x)	MASK_PORT1 &= ~(0x01 << x)

#define setBit2(x)	MASK_PORT2 |= 0x01 << x
#define clrBit2(x)	MASK_PORT2 &= ~(0x01 << x)


#define  RST(x)  	((x)==0?(digitalWrite(11, LOW)): (digitalWrite(11, HIGH)))
#define  SDA(x)  	((x)==0?(clrBit1(MASK_SDA)): (setBit1(MASK_SDA)))
#define  SCL(x)  	((x)==0?(clrBit1(MASK_SCL)): (setBit1(MASK_SCL)))

#define  DC(x)  	((x)==0?(clrBit2(MASK_DC)): (setBit2(MASK_DC)))
#define  CS(x)  	((x)==0?(clrBit2(MASK_CS)):  (setBit2(MASK_CS)))

#define InitPort() DDRB |= B00111000;DDRD |= B11000000
//MASK_DDR1 |= (1<<MASK_RST)|(1<<MASK_SDA)|(1<<MASK_SCL);MASK_DDR2 |= (1<<MASK_DC)|(1<<MASK_CS)

//---------------------------------------------------------------------------------------

void Display_testGPIO(unsigned char x){
	InitPort();

	RST(x);
	SDA(x);
	SCL(x);
	DC(x);
	CS(x);
}

void Delay_nms(unsigned int MS) {
	while (MS != 0) {
		MS--;
	}
}

uint and_e[16] = {
		0x8000,
		0x4000,
		0x2000,
		0x1000,
		0x0800,
		0x0400,
		0x0200,
		0x0100,
		0x0080,
		0x0040,
		0x0020,
		0x0010,
		0x0008,
		0x0004,
		0x0002,
		0x0001,
};



void Displayer_WriteData(unsigned int dat) {
	unsigned char i;
//	unsigned int and = 0x8000;
	//SCL(0);
	for (i = 0; i < 16; i++) {

		if (dat & and_e[i]) {
			SDA(1);
		} else {
			SDA(0);
		}
		SCL(1);
		SCL(0);
	}
}

void Displayer_WriteRegister(unsigned char dat) {
	unsigned char i;
	unsigned char ad = 0x80;
	DC(0);
	CS(0);
	for (i = 8; i < 16; i++) {
		SCL(0);
		if (dat & ad) {
			SDA(1);
		} else {
			SDA(0);
		}

		SCL(1);
		SCL(0);

		ad = ad >> 1;
	}
	DC(1);
}

void Diaplayer_WriteCommand(unsigned char index, unsigned int val) {
	Displayer_WriteRegister(index);
	Displayer_WriteData(val);
	CS(1);
}

void Displayer_ClearScreen(void) {
	unsigned int i, j;

	Diaplayer_WriteCommand(0x44, (131) * 256 ); //x start point
	Diaplayer_WriteCommand(0x45, (131) * 256 ); //y start point
	Diaplayer_WriteCommand(0x21, (131) * 256 + (131)); //RAM address set
	Displayer_WriteRegister(0x22);


	SDA(0);
	for (i = 0; i < 132; i++) {
		for (j = 0; j < 2112; j++) {//2112 = 132*16
				SCL(1);
				SCL(0);
		}
	}



}




bool Displayer_InitDevice(void) {

//	pinMode(MASK_DC, OUTPUT);
//	pinMode(MASK_RST, OUTPUT);
//	pinMode(MASK_CLK, OUTPUT);
//	pinMode(MASK_CS, OUTPUT);
//	pinMode(MASK_SDA, OUTPUT);

	InitPort();

	RST(0);
	RST(1);

	Diaplayer_WriteCommand(0x10, 0x2F84);
	Diaplayer_WriteCommand(0x11, 0x000C);
	Diaplayer_WriteCommand(0x07, 0x0021);
	Diaplayer_WriteCommand(0x28, 0x0006);
	Diaplayer_WriteCommand(0x28, 0x0005);
	Diaplayer_WriteCommand(0x27, 0x057F);
	Diaplayer_WriteCommand(0x29, 0x89A1);
	Diaplayer_WriteCommand(0x00, 0x0001);
	Delay_nms(150);
	Diaplayer_WriteCommand(0x29, 0x80B0);
	Delay_nms(50);
	Diaplayer_WriteCommand(0x29, 0xFFFE);
	Diaplayer_WriteCommand(0x07, 0x0023);
	Diaplayer_WriteCommand(0x07, 0x0033);
	Diaplayer_WriteCommand(0x01, 0x2183);
	Diaplayer_WriteCommand(0x2F, 0xFFFF);
	Diaplayer_WriteCommand(0x2C, 0x8000);
	Diaplayer_WriteCommand(0x03, 0x6808); //6830//0x6808
	Diaplayer_WriteCommand(0x27, 0x0570);
	Diaplayer_WriteCommand(0x02, 0x0300);
	Diaplayer_WriteCommand(0x0B, 0x580C);
	Diaplayer_WriteCommand(0x12, 0x0609);
	Diaplayer_WriteCommand(0x13, 0x3100);
	Diaplayer_WriteCommand(0x2A, 0x1DD0);
	Diaplayer_WriteCommand(0x2B, 0x0A90);
	Diaplayer_WriteCommand(0x2D, 0x310F);
	Delay_nms(150);
	Diaplayer_WriteCommand(0x1E, 0x00BF);
	Delay_nms(1);
	Diaplayer_WriteCommand(0x1E, 0x0000);
	Delay_nms(100);

	Displayer_ClearScreen();
	return successful;
}


#define Black_color 0xFFFF
#define White_color 0x0000

void Displayer_DisplayString(char *s, unsigned char x, unsigned char y,	bool inversion) {
	unsigned char j, k;
	unsigned int postion_x, postion_y;
	postion_x = x * 6;
	postion_y = y * 8;


	while (*s != 0) {
		Diaplayer_WriteCommand(0x44, (131 - postion_x ) * 256 + (131 - postion_x - 5 )); //x start point
		Diaplayer_WriteCommand(0x45, (131 - postion_y ) * 256 + (131 - postion_y - 7 )); //y start point
		Diaplayer_WriteCommand(0x21, (131 - postion_y ) * 256 + (131 - postion_x )); //RAM address set
		Displayer_WriteRegister(0x22);

		for (j = 0; j < 6; j++) {
			if (inversion == false) {
				for (k = 0; k < 8; k++) {
					if ((F6x8[(*s - 32)][j] & (0x01 << k)) != 0) {
						Displayer_WriteData(Black_color);
					} else {
						Displayer_WriteData(White_color);
					}
				}
			} else {
				for (k = 0; k < 8; k++) {
					if ((F6x8[(*s - 32)][j] & (0x01 << k)) != 0) {
						Displayer_WriteData(White_color);
					} else {
						Displayer_WriteData(Black_color);
					}
				}

			}
		}

		if(postion_x < (132-12))postion_x += 6;
		else
			break;
		/*if (postion_x >= 180) {
			postion_x = 0;
			postion_y += 8;
			if (postion_y >= 120) {
				postion_y = 0;
			}
		}*/
		s++;
	}
}


//char *numberStr[] = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
char *numberStr [10] = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

const int seperate[5] = { 1, 10, 100, 1000, 10000 };
#define ABS(x)	((x)<0?(-(x)):(x))
uchar LengthOf(int data) {
	uchar i;
	for (i = 0; i < 5; i++) {
		if ((data / seperate[4 - i]) != 0)
			return (5 - i);
	}
	return 1;
}

void Displayer_DisplayDecimal(int dataInput, uchar x, uchar y, uchar length,
		bool inversion) {

	uint i;
	uchar dsplyNum;
	uchar realLength;
	int number = dataInput;
	int tmpPosition_x, tmpPosition_y;

	if (number < 0)
		number = ABS(number);
	realLength = LengthOf(number);
	if (realLength < 5)
		Displayer_DisplayString(" ", x + ((4 - realLength)), y, inversion);

	tmpPosition_x = x + (6 - length);
	tmpPosition_y = y;
	for (i = 0; i < length; i++) {
		dsplyNum = (uchar) ((number / seperate[length - i - 1]) % 10);

		if (dsplyNum == 0) {
			if ((length - i) > realLength) //insert space
					{
				Displayer_DisplayString( " ", tmpPosition_x, tmpPosition_y,inversion);
			} else //insert "0"
			{

				Displayer_DisplayString("0",tmpPosition_x, tmpPosition_y,  inversion);
			}
		} else {
			Displayer_DisplayString( numberStr[dsplyNum],tmpPosition_x, tmpPosition_y,	inversion);
		}
		tmpPosition_x++;
	}

	if (dataInput < 0) {
		Displayer_DisplayString( "-",x + (5 - realLength), y, inversion);

	} else
		Displayer_DisplayString( " ",x + (5 - realLength), y, inversion);
}


/*
 * Set a rectangle ram in the displayer for displaying
 */
//void Displayer_SetDisplayRectangle(uchar x, uchar y, uchar width, uchar hight){
//
//	x = 132 - x - width;
//	y = 132 - y - hight;
//
//	Diaplayer_WriteCommand(0x44, ((x + width -1) * 256 + x )); //x start point
//	Diaplayer_WriteCommand(0x45, ((y + hight -1) * 256 + y )); //y start point
//	Diaplayer_WriteCommand(0x21, ((y + hight -1) * 256 + (x + width -1))); //RAM address set
//	Displayer_WriteRegister(0x22);
//
//}


//uchar x_rectangle, y_rectangle;
//uchar hight_rectangle, width_rectangle;
//
//void Displayer_ClearRectangleBuffer(void) {
//	uchar h;
//	uchar w;
//
//	for (w = 0; w < Displayer_ressolution_width; w++) {
//		for (h = 0; h < Displayer_ressolution_hight; h++) {
//			Displayer_rectangleBuffer[h][w] = 0;
//		}
//	}
//}
//
//void Displayer_DisplayerRectangleBuffer(void){
//	uchar w, h;
//
//	Displayer_SetDisplayRectangle(x_rectangle, y_rectangle, width_rectangle, hight_rectangle);
//
//	for (w = x_rectangle; w < width_rectangle; w ++) {
//		for (h = y_rectangle; h < hight_rectangle; h ++) {
//			Displayer_WriteData(Displayer_rectangleBuffer[h][w]);
//		}
//	}
//
//
//}


/*
void Displayer_DisplayerRectangle_Test(ushort* buffer, uchar x, uchar y, uchar width, uchar hight)
{
	ushort 	h,w;
	ushort* tmpPtr;
	ushort 	tmpData;
	tmpPtr = buffer;

	Diaplayer_WriteCommand(0x44, (x + width + 1) * 256 + (x + 2)); //x start point
	Diaplayer_WriteCommand(0x45, (y + hight + 1 ) * 256 + (y + 2)); //y start point
	Diaplayer_WriteCommand(0x21, (y + 2) * 256 + (y + 2)); //RAM address set
	Displayer_WriteRegister(0x22);

	SDA(0);

	for(w=0;w<width;w++){
		for(h=0;h<hight;h++){
			tmpData = (*tmpPtr)>>3;
			tmpData &= 0x001f;
			Displayer_WriteData(tmpData);
			tmpPtr ++;
		}
		SDA(0);
	}
}*/
