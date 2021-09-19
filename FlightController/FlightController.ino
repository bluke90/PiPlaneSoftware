/*
 Name:		FlightController.ino
 Created:	9/16/2021 9:53:14 PM
 Author:	blake.ganzerla
*/

// the setup function runs once when you press reset or power the board
#include "Gyro.h"
#include "Controller.h"
#include <Wire.h>
#include <Servo.h>

Servo servo_y;
Servo servo_z;

int servo_y_pos = 0;
int servo_z_pos = 0;

void setup() {
    servo_y.attach(7);
    servo_z.attach(8);
}

void loop() {
    // put your main code here, to run repeatedly:
    //TestServoY(servo_y);
    //TestServoZ(servo_z);
    Controller control(7, 9, 8);
    while (true) {
        control.AlterPitch(0.7);
        delay(500);
        control.AlterPitch(0.2);
        delay(500);
        control.AlterPitch(0.9);
        delay(500);
        control.AlterPitch(0.5);

    }
    /*
    servo_z_pos = IncreaseZ(servo_z, servo_z_pos);
    delay(500);
    servo_z_pos = DecreaseZ(servo_z, servo_z_pos);
    delay(500);
    servo_z_pos = ZeroZ(servo_z, servo_z_pos);
    delay(500);


    servo_y_pos = IncreaseY(servo_y, servo_y_pos);
    delay(500);
    servo_y_pos = DecreaseY(servo_y, servo_y_pos);
    delay(500);
    servo_y_pos = ZeroY(servo_y, servo_y_pos);
    delay(500);
    */
    Gyro gyro_0;
    gyro_0.InitGyro();
    while (true) {
        gyro_0.StartGyroRead();
        delay(1000);
    }

}


static void TestServoY(Servo servo) {
    int pos = 130;
    servo.write(pos);
    delay(1000);
    pos = 70;
    servo.write(pos);
    delay(1000);
    pos = 100;
    servo.write(pos);
    delay(1000);
}
static void TestServoZ(Servo servo) {
    int pos = 100;
    servo.write(pos);
    delay(1000);
    pos = 50;
    servo.write(pos);
    delay(1000);
    pos = 75;
    servo.write(pos);
    delay(1000);
}
static int IncreaseZ(Servo servo, int CurrentY_pos) {
    int pos = 130;
    servo.write(pos);
    return pos;
}
static int DecreaseZ(Servo servo, int CurrentY_pos) {
    int pos = 70;
    servo.write(pos);
    return pos;
}
static int ZeroZ(Servo servo, int CurrentY_pos) {
    int pos = 101;
    servo.write(pos);
    return pos;
}
static int IncreaseY(Servo servo, int CurrentZ_pos) {
    int pos = 115;
    servo.write(pos);
    return pos;
}
static int DecreaseY(Servo servo, int CurrentZ_pos) {
    int pos = 50;
    servo.write(pos);
    return pos;
}
static int ZeroY(Servo servo, int CurrentZ_pos) {
    int pos = 90;
    servo.write(pos);
    return pos;
}


