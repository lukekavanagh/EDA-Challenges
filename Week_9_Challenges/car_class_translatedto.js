"use strict";

function Car (){

	this.make = make;
	this.model = model;
	this.speed = speed;
	this.turnleft = turnLeft;
	this.turnright = turnRight;
	this.milesTravelled = milesTravelled;
	this.timeTravelled = timeTravelled;
	this.time = time;
	this.totalSpeed = totalSpeed;
	this.distance = distance;

}

Car.prototype.CheckSpeed = function(speed) { // create method Check speed which is a property of car. When you set a propery as a function it is a method in javascript
	
	return this.Speed;
};

Car.prototype.Accelerate = function(speed){

	if (this.speed > 0)
	{
		this.accelerate += this.speed;
	}
	return accelerate;
}
Car.prototype.TimeToDestination = function(distance, time);
{
	return distance / totalSpeed;

}

var dodge = new car();
