﻿using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour {

	// Use this for initialization
	void FixedUpdate() {
		Debug.Log ("FixedUpdate time :" + Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update() {
		Debug.Log ("Update time :" + Time.deltaTime);
	}
}
