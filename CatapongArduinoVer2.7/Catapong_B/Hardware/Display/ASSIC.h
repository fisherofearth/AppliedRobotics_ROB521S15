/*
 * ASSIC.h
 *
 *  Created on: Apr 29, 2013
 *      Author: Fisher
 */

#ifndef ASSIC_H_
#define ASSIC_H_



const unsigned char F6x8[][6] =
{
		
//		  (0) !(1) "(2) #(3) $(4) %(5) &(6) '(7) ((8) )(9) *(10) +(11) ,(12) -(13) .(14) /(15) 0(16) 1(17) 2(18) 3(19) 4(20) 5(21) 6(22) 7(23)
//		 8(24) 9(25) :(26) ;(27) <(28) =(29) >(30) ?(31) @(32) A(33) B(34) C(35) D(36) E(37) F(38) G(39) H(40) I(41) J(42) K(43) L(44) M(45) N(46) O(47)
//		 P(48) Q(49) R(50) S(51) T(52) U(53) V(54) W(55) X(56) Y(57) Z(58) [(59) \(60) ](61) ^(62) _(63) '(64) a(65) b(66) c(67) d(68) e(69) f(70) g(71)
//		 h(72) i(73) j(74) k(75) l(76) m(77) n(78) o(79) p(80) q(81) r(82) s(83) t(84) u(85) v(86) w(87) x(88) y(89) z(90) {(91) |(92) }(93) ~(94)

		{0x00,0x00,0x00,0x00,0x00,0x00},/*" ",0*/

		{0x00,0x00,0x5E,0x00,0x00,0x00},/*"!",1*/

		{0x00,0x02,0x01,0x02,0x01,0x00},/*""",2*/

		{0x14,0x74,0x1E,0x74,0x1E,0x14},/*"#",3*/

		{0x64,0x4A,0xFF,0x52,0x26,0x00},/*"$",4*/

		{0x04,0x4A,0x34,0x2C,0x52,0x20},/*"%",5*/

		{0x30,0x4E,0x5A,0x2E,0x58,0x40},/*"&",6*/

		{0x02,0x01,0x00,0x00,0x00,0x00},/*"'",7*/

		{0x00,0x00,0x00,0x3C,0x42,0x81},/*"(",8*/

		{0x00,0x81,0x42,0x3C,0x00,0x00},/*")",9*/

		{0x14,0x08,0x3E,0x08,0x14,0x00},/*"*",10*/

		{0x08,0x08,0x3E,0x08,0x08,0x00},/*"+",11*/

		{0x80,0x40,0x00,0x00,0x00,0x00},/*",",12*/

		{0x08,0x08,0x08,0x08,0x08,0x00},/*"-",13*/

		{0x00,0x40,0x00,0x00,0x00,0x00},/*".",14*/

		{0x80,0x60,0x18,0x06,0x01,0x00},/*"/",15*/

		{0x3C,0x42,0x42,0x42,0x3C,0x00},/*"0",16*/

		{0x00,0x44,0x7E,0x40,0x00,0x00},/*"1",17*/

		{0x44,0x62,0x52,0x52,0x4E,0x00},/*"2",18*/

		{0x24,0x42,0x4A,0x4A,0x36,0x00},/*"3",19*/

		{0x10,0x28,0x24,0x7E,0x20,0x00},/*"4",20*/

		{0x2E,0x4A,0x4A,0x4A,0x32,0x00},/*"5",21*/

		{0x3C,0x4A,0x4A,0x4A,0x30,0x00},/*"6",22*/

		{0x06,0x02,0x72,0x0E,0x02,0x00},/*"7",23*/

		{0x34,0x4A,0x52,0x4A,0x34,0x00},/*"8",24*/

		{0x0C,0x52,0x52,0x52,0x3C,0x00},/*"9",25*/

		{0x00,0x00,0x48,0x00,0x00,0x00},/*":",26*/

		{0x00,0x00,0xC8,0x00,0x00,0x00},/*";",27*/

		{0x00,0x08,0x14,0x22,0x42,0x41},/*"<",28*/

		{0x28,0x28,0x28,0x28,0x28,0x00},/*"=",29*/

		{0x00,0x41,0x22,0x24,0x14,0x08},/*">",30*/

		{0x04,0x02,0x52,0x0A,0x04,0x00},/*"?",31*/

		{0x00,0x7C,0x82,0xBA,0xA6,0x7C},/*"@",32*/

		{0x40,0x78,0x26,0x3C,0x60,0x40},/*"A",33*/

		{0x42,0x7E,0x4A,0x4A,0x36,0x00},/*"B",34*/

		{0x3C,0x42,0x42,0x42,0x26,0x00},/*"C",35*/

		{0x42,0x7E,0x42,0x42,0x3C,0x00},/*"D",36*/

		{0x42,0x7E,0x4A,0x5E,0x42,0x00},/*"E",37*/

		{0x42,0x7E,0x4A,0x1A,0x02,0x00},/*"F",38*/

		{0x3C,0x66,0x42,0x52,0x36,0x10},/*"G",39*/

		{0x42,0x7E,0x10,0x10,0x7E,0x42},/*"H",40*/

		{0x00,0x42,0x7E,0x42,0x00,0x00},/*"I",41*/

		{0x80,0x82,0x82,0x7E,0x02,0x02},/*"J",42*/

		{0x42,0x7E,0x4A,0x14,0x66,0x42},/*"K",43*/

		{0x42,0x7E,0x42,0x40,0x40,0x40},/*"L",44*/

		{0x7E,0x0E,0x70,0x0E,0x7E,0x00},/*"M",45*/

		{0x42,0x7E,0x08,0x10,0x7E,0x02},/*"N",46*/

		{0x3C,0x42,0x42,0x42,0x3C,0x00},/*"O",47*/

		{0x42,0x7E,0x4A,0x0A,0x0E,0x00},/*"P",48*/

		{0x3C,0x62,0x62,0xC2,0xBC,0x00},/*"Q",49*/

		{0x42,0x7E,0x4A,0x1A,0x6E,0x40},/*"R",50*/

		{0x64,0x4A,0x4A,0x52,0x26,0x00},/*"S",51*/

		{0x02,0x42,0x7E,0x42,0x02,0x00},/*"T",52*/

		{0x02,0x3E,0x40,0x40,0x3E,0x02},/*"U",53*/

		{0x02,0x1E,0x60,0x32,0x0E,0x02},/*"V",54*/

		{0x0E,0x70,0x0E,0x78,0x06,0x00},/*"W",55*/

		{0x42,0x66,0x5A,0x66,0x42,0x00},/*"X",56*/

		{0x02,0x4E,0x7A,0x46,0x02,0x00},/*"Y",57*/

		{0x42,0x62,0x5A,0x4E,0x42,0x00},/*"Z",58*/

		{0x00,0x00,0xFF,0x81,0x81,0x00},/*"[",59*/

		{0x00,0x02,0x0C,0x30,0x40,0x00},/*"\",60*/

		{0x00,0x81,0x81,0xFF,0x00,0x00},/*"]",61*/

		{0x00,0x02,0x01,0x02,0x00,0x00},/*"^",62*/

		{0x80,0x80,0x80,0x80,0x80,0x80},/*"_",63*/

		{0x02,0x01,0x00,0x00,0x00,0x00},/*"'",64*/

		{0x00,0x24,0x54,0x54,0x78,0x40},/*"a",65*/

		{0x02,0x7E,0x48,0x48,0x30,0x00},/*"b",66*/

		{0x00,0x30,0x48,0x48,0x48,0x00},/*"c",67*/

		{0x00,0x30,0x48,0x4A,0x7E,0x40},/*"d",68*/

		{0x00,0x30,0x58,0x58,0x50,0x00},/*"e",69*/

		{0x00,0x48,0x7E,0x4A,0x4A,0x02},/*"f",70*/

		{0x00,0xF8,0xD8,0xD8,0xD8,0xC8},/*"g",71*/

		{0x42,0x7E,0x48,0x08,0x78,0x40},/*"h",72*/

		{0x00,0x48,0x7A,0x40,0x00,0x00},/*"i",73*/

		{0x80,0x80,0x88,0x7A,0x00,0x00},/*"j",74*/

		{0x42,0x7E,0x60,0x78,0x48,0x48},/*"k",75*/

		{0x00,0x00,0x7E,0x40,0x00,0x00},/*"l",76*/

		{0x78,0x08,0x78,0x08,0x78,0x00},/*"m",77*/

		{0x48,0x78,0x48,0x08,0x78,0x40},/*"n",78*/

		{0x00,0x30,0x48,0x48,0x30,0x00},/*"o",79*/

		{0x88,0xF8,0xC8,0x48,0x38,0x00},/*"p",80*/

		{0x00,0x30,0x48,0xC8,0xF8,0x80},/*"q",81*/

		{0x48,0x78,0x50,0x08,0x08,0x00},/*"r",82*/

		{0x00,0x58,0x68,0x68,0x68,0x00},/*"s",83*/

		{0x00,0x08,0x7C,0x48,0x40,0x00},/*"t",84*/

		{0x08,0x78,0x40,0x48,0x78,0x40},/*"u",85*/

		{0x08,0x18,0x68,0x20,0x18,0x08},/*"v",86*/

		{0x18,0x60,0x18,0x70,0x18,0x00},/*"w",87*/

		{0x48,0x68,0x30,0x58,0x48,0x00},/*"x",88*/

		{0x88,0x98,0x68,0x30,0x18,0x08},/*"y",89*/

		{0x00,0x48,0x68,0x58,0x48,0x00},/*"z",90*/

		{0x00,0x00,0x08,0xFF,0x81,0x00},/*"{",91*/

		{0x00,0x00,0x00,0xFF,0x00,0x00},/*"|",92*/

		{0x00,0x81,0xFF,0x08,0x00,0x00},/*"}",93*/

		{0x01,0x00,0x00,0x01,0x01,0x00}/*"~",94*/




};


#endif /* ASSIC_H_ */