﻿using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {

	int myInt = 5;

	// Use this for initialization
	void Start () {
		myInt = MultiplyByTwo(myInt);
		Debug.Log(myInt);
	}

	int MultiplyByTwo(int number) {
		int ret;
		ret = number * 2;
		return ret;
	}

}
