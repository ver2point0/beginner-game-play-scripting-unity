using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	int numberOfEnemies = 5;
	// Use this for initialization
	void Start() {
		for(int i = 0; i < numberOfEnemies; i++) {
			Debug.Log("Creating enemy number: " + i);
		}
	}
}
