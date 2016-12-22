using UnityEngine;
using System.Collections;

public class ExampleSyntax : MonoBehaviour {

	public int myInt = 10;

	int MyFunction(int number) {
		int ret = number * myInt;
		return ret;
	}
}
