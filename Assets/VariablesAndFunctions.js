#pragma strict

var myInt : int = 10;

function Start () {
	myInt = MultiplyByTwo(myInt);
	Debug.Log(myInt);
}

function MultiplyByTwo(number : int) : int {
	var returnValue : int;
	returnValue = number * 2;
	return returnValue;
}
