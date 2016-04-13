################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ../makefile.init

RM := rm -rf

# All of the sources participating in the build are defined here
-include sources.mk
-include subdir.mk
-include arduino/core/avr-libc/subdir.mk
-include arduino/core/subdir.mk
-include Libraries/Wire/utility/subdir.mk
-include Libraries/Wire/subdir.mk
-include Libraries/Servo/arch/avr/subdir.mk
-include Hardware/Keyboard/subdir.mk
-include Hardware/IRSensor/subdir.mk
-include Hardware/CPServo/subdir.mk
-include objects.mk

ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(ASM_DEPS)),)
-include $(ASM_DEPS)
endif
ifneq ($(strip $(PDE_DEPS)),)
-include $(PDE_DEPS)
endif
ifneq ($(strip $(INO_DEPS)),)
-include $(INO_DEPS)
endif
ifneq ($(strip $(S_UPPER_DEPS)),)
-include $(S_UPPER_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
endif

-include ../makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 
AR += \
arduino.ar \

ELF += \
Catapong_A.elf \

EEP += \
Catapong_A.eep \

FLASH_IMAGE += \
Catapong_A.hex \


# All Target
all: Catapong_A

# Tool invocations
Catapong_A: $(FLASH_IMAGE)
	@echo 'Building target: $@'
	@echo 'Printing size:'
	"C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/tools/avr/bin/avr-size" -A "C:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release/Catapong_A.elf"
	@echo 'Finished building target: $@'
	@echo ' '

arduino.ar: $(AR_OBJ)
	@echo 'Starting archiver'
	"C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/tools/avr/bin/avr-ar" rcs "C:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release/arduino.ar"   $(AR_OBJ)
	@echo 'Finished building: $@'
	@echo ' '

Catapong_A.elf: $(LINK_OBJ) $(AR)
	@echo 'Starting combiner'
	"C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/tools/avr/bin/avr-gcc" -Os -Wl,--gc-sections -mmcu=atmega328p -o "C:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release/Catapong_A.elf"   $(LINK_OBJ) $(AR)  "C:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release/arduino.ar" "-LC:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release" -lm
	@echo 'Finished building: $@'
	@echo ' '

Catapong_A.eep: $(ELF)
	@echo 'Create eeprom image'
	"C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/tools/avr/bin/avr-objcopy" -O ihex -j .eeprom --set-section-flags=.eeprom=alloc,load --no-change-warnings --change-section-lma .eeprom=0 "C:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release/Catapong_A.elf" "C:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release/Catapong_A.eep"
	@echo 'Finished building: $@'
	@echo ' '

Catapong_A.hex: $(EEP)
	@echo 'Create Flash image (ihex format)'
	"C:/ProgramQuickUse/arduino-1.5.5-r2/hardware/tools/avr/bin/avr-objcopy" -O ihex -R .eeprom "C:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release/Catapong_A.elf" "C:/Users/Fisher/ArduinoEclipse2015.ws/Catapong_A/Release/Catapong_A.hex"
	@echo 'Finished building: $@'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(C_UPPER_DEPS)$(PDE_DEPS)$(C_DEPS)$(AR)$(EEP)$(FLASH_IMAGE)$(CC_DEPS)$(AR_OBJ)$(C++_DEPS)$(LINK_OBJ)$(CXX_DEPS)$(ASM_DEPS)$(INO_DEPS)$(SIZEDUMMY)$(S_UPPER_DEPS)$(ELF)$(CPP_DEPS) Catapong_A
	-@echo ' '

.PHONY: all clean dependents
.SECONDARY:

-include ../makefile.targets
