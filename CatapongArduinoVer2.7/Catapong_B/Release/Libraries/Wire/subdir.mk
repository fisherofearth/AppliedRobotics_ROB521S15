################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/arduino/avr/libraries/Wire/Wire.cpp 

LINK_OBJ += \
./Libraries/Wire/Wire.cpp.o 

CPP_DEPS += \
./Libraries/Wire/Wire.cpp.d 


# Each subdirectory must supply rules for building sources it contributes
Libraries/Wire/Wire.cpp.o: C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/arduino/avr/libraries/Wire/Wire.cpp
	@echo 'Building file: $<'
	@echo 'Starting C++ compile'
	"C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/tools/avr/bin/avr-g++" -c -g -Os -fno-exceptions -ffunction-sections -fdata-sections -MMD -mmcu=atmega328p -DF_CPU=16000000L -DARDUINO=155-r2 -DARDUINO_AVR_UNO -DARDUINO_ARCH_AVR    -I"C:\ProgramQuickUse\arduino-1.5.5-r2\hardware\arduino\avr\cores\arduino" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\hardware\arduino\avr\variants\standard" -I"C:\Users\Fisher\Arduino\libraries\I2cCMD" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\hardware\arduino\avr\libraries\Wire" -I"C:\ProgramQuickUse\arduino-1.5.5-r2\hardware\arduino\avr\libraries\Wire\utility" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -D__IN_ECLIPSE__=1 -x c++ "$<"  -o  "$@"   -Wall
	@echo 'Finished building: $<'
	@echo ' '


