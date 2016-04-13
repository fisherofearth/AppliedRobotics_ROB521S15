/*
 * Display.h
 *
 *  Created on: Apr 23, 2015
 *      Author: Fisher
 */

#ifndef DISPLAY_H_
#define DISPLAY_H_



#define Displayer_ressolution_width	132
#define Displayer_ressolution_hight	132


#define uchar 	unsigned char
#define successful 		1
#define unsuccessful 	0
#define bool 	unsigned char
#define uint   unsigned int

typedef struct {
	uchar R;
	uchar G;
	uchar B;
}DISPLAYER_COLOR;


//ushort Displayer_rectangleBuffer[Displayer_ressolution_hight][Displayer_ressolution_width]; //This buffer should be filled, then it will be updated into the ram of displayer.
void Display_testGPIO(unsigned char x);
extern bool Displayer_InitDevice(void);
extern void Displayer_DisplayString(char* s,uchar x, uchar y, bool inversion);
extern void Displayer_ClearScreen(void);
extern void Displayer_DisplayDecimal(int dataInput, uchar x, uchar y, uchar length, bool inversion);
extern void Diaplayer_WriteCommand(unsigned char index, unsigned int val);
extern void Displayer_WriteRegister(unsigned char dat);
extern void Displayer_WriteData(unsigned int dat);
extern void Displayer_SetDisplayRectangle(uchar x, uchar y, uchar width, uchar hight);

//extern void Displayer_DisplayerRectangle_Test(ushort* buffer, uchar x, uchar y, uchar width, uchar hight);

#endif /* DISPLAY_H_ */
