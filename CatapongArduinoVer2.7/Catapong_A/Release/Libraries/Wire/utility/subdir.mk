################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/arduino/avr/libraries/Wire/utility/twi.c 

C_DEPS += \
./Libraries/Wire/utility/twi.c.d 

LINK_OBJ += \
./Libraries/Wire/utility/twi.c.o 


# Each subdirectory must supply rules for building sources it contributes
Libraries/Wire/utility/twi.c.o: C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/arduino/avr/libraries/Wire/utility/twi.c
	@echo 'Building file: $<'
	@echo 'Starting C compile'
	"C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/tools/avr/bin/avr-gcc" -c -g -Os -ffunction-sections -fdata-sections -MMD -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=155-r2 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR    -I"C:\ProgramQuickUse\arduino-1.5.5-r2\hardware\arduino\avr\cores\arduino" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\hardware\arduino\avr\variants\standard" -I"C:\Users\Fisher\Arduino\libraries\I2cCMD" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\hardware\arduino\avr\libraries\Wire" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\hardware\arduino\avr\libraries\Wire\utility" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\libraries\Servo" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\libraries\Servo\src" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\libraries\Servo\arch\avr" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 "$<"  -o  "$@"   -Wall
	@echo 'Finished building: $<'
	@echo ' '


