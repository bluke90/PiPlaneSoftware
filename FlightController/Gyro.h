// Gyro.h

#ifndef _GYRO_h
#define _GYRO_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
#else
	#include "WProgram.h"
#endif


#endif

#include <Wire.h>

class Gyro {
public:
    bool SensorActive;
    // Get
    float GetPitch() { return Pitch; }
    float GetRoll() { return Roll; }
    float GetYaw() { return Yaw; }
    float GetAccelX() { return AccelX; }
    float GetAccelY() { return AccelY; }
    float GetAccelZ() { return AccelZ; }

    void StartGyroRead() {
        while (true) {
            Wire.beginTransmission(MPU_addr);
            Wire.write(0x3B);
            Wire.endTransmission(false);
            Wire.requestFrom(MPU_addr, 12, true);
            AccelX = Wire.read() << 8 | Wire.read();
            AccelY = Wire.read() << 8 | Wire.read();
            AccelZ = Wire.read() << 8 | Wire.read();
            int xAng = map(AccelX, minVal, maxVal, -90, 90);
            int yAng = map(AccelY, minVal, maxVal, -90, 90);
            int zAng = map(AccelZ, minVal, maxVal, -90, 90);
     

            Roll = RAD_TO_DEG * (atan2(-yAng, -zAng) + PI);
            Pitch = RAD_TO_DEG * (atan2(-xAng, -zAng) + PI);
            Yaw = RAD_TO_DEG * (atan2(-yAng, -xAng) + PI);


            Serial.print("Roll= ");
            Serial.println(Roll);

            Serial.print("Pitch= ");
            Serial.println(Pitch);

            Serial.print("Yaw= ");
            Serial.println(Yaw);
            Serial.println("-----------------------------------------");
            delay(400);
        };
    };
    bool InitGyro() {
        Wire.begin();
        Wire.beginTransmission(MPU_addr);
        Wire.write(0x6B);
        Wire.write(0);
        Wire.endTransmission(true);
        Serial.begin(9600);
        return true;
    };

private:
    // Gyro
    float Pitch, Roll, Yaw;
    // Accel
    float AccelX, AccelY, AccelZ;
    // Tilt
    int minVal = 265;
    int maxVal = 402;
    // Constants
    const int MPU_addr = 0x68;
};

