"use strict";

function MazeSpace(directions){
	var i;
	for (i=0; i < directions.length; i +=1){
		this[directions[i]] = false; //dynamically create properties for each direction
	}
	}/// this for loop goes through each element in the array one by one and create a corresponding property in the MazeSpace object and sets its property value to false
	


MazeSpace.prototype.setWall = function (direction) {
	this[direction] = true; //we receive the propery in a variable and set the corresponding wall to true
}