#pragma strict

public var coffeeTemperature:float = 85.0f;
public var hotLimitTemperature:float = 70.0f;
public var coldLimitTemperature:float = 40.0f;

function Update() {
	if(Input.GetKeyDown(KeyCode.Space)) {
		TemperatureTest();
	}
	
	coffeeTemperature -= Time.deltaTime * 5f;
}

function TemperatureTest() {
	if(coffeeTemperature > hotLimitTemperature) {
		Debug.Log("Coffee is too hot.");
	} else if(coffeeTemperature < coldLimitTemperature) {
		Debug.Log("Coffee is too cold.");
	} else {
		Debug.Log("Coffee is just right.");
	}
}