// 
// 
// 

#include "Controller.h"

void Controller::AlterPitch(float input)
{
	// Neutral
	if (input <= 0.55 && input >= 0.45) {
		this->Pitch.write(60);
		this->Pitch.detach();
	} else {
		this->Pitch.attach(this->Pitch_pin);
	};

	// 90 Deg
	if (input <= 1.0 && input >= 0.95) {
		this->Pitch.write(90);
	};
	if (input < 0.95 && input >= 0.85) {
		this->Pitch.write(85);
	};
	if (input < 0.85 && input >= 0.80) {
		this->Pitch.write(80);
	};
	if (input < 0.80 && input >= 0.72) {
		this->Pitch.write(75);
	};
	if (input < 0.72 && input >= 0.65) {
		this->Pitch.write(70);
	};
	if (input <= 0.65 && input >= 0.55) {
		this->Pitch.write(65);
	};
	// 60 Deg
	if (input <= 0.45 && input > 0.35) {
		this->Pitch.write(55);
	};
	if (input <= 0.35 && input > 0.27) {
		this->Pitch.write(50);
	};
	if (input <= 0.27 && input > 0.20) {
		this->Pitch.write(45);
	};
	if (input > 0.15 && input <= 0.20) {
		this->Pitch.write(40);
	};
	if (input > 0.05 && input <= 0.15) {
		this->Pitch.write(35);
	};
	if (input >= 0 && input <= 0.05) {
		this->Pitch.write(30);
	};
	delay(50);

}


Controller ;

