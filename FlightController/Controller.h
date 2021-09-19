// MyClass.h

#ifndef _MyClass_h
#define _MyClass_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
#else
	#include "WProgram.h"
#endif

#include <Servo.h>

class Controller
{
 public:
	 void AlterPitch(float input);
	 Controller(int sPitch, int sRoll, int sYaw) {
		 Pitch_pin = sPitch;
		 Roll_pin = sRoll;
		 Yaw_pin = sYaw;
	 };



private:
	Servo Pitch, Roll, Yaw;
	int Pitch_pin, Roll_pin, Yaw_pin;
	int maxPitch, minPitch;
	int maxRoll, minRoll;
	int maxYaw, minYaw;
	
};

extern Controller ;

#endif

