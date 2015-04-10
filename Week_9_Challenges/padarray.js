"use strict";

function PadOrginal(OriginalArray, padding, minsize ){

	this.Array = [] array;
	this.padding = int padding;
	this.minsize = int minsize;

int spacesToAdd = minsize - array.length;

if (padding === null)

	{
		padding = 0;
	}

	for (var index = 0; i < spacesToAdd; i++) {

		Array += padding;
	}
	return array;
}

function PadNew(NewArray, Padding, MinSize){

	this.NewArray = [] array;
	this.Padding = int Padding;
	this.minsize = int minsize;

	var NewArray = new [];

	var spacesToAdd = minsize - array.length;

	if (Padding === null)
	{
		Padding = 0;
	}
	for(var item in array)
	{
		NewArray += item;
	}

	for (var index = 0; i < spacesToAdd.length; i++) {
		
		NewArray += index;
	}

	return Newarray;
}