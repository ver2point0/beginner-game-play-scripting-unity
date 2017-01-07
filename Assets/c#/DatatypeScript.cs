using UnityEngine;
using System.Collections;

public class DatatypeScript : MonoBehaviour {
	
	void Start() {
		//value type variable
		Vector3 pos = transform.position;
		pos = new Vector3(0, 2, 0);

		//reference type variable
		Transform tran = transform;
		tran.position = new Vector3(0, 2, 0);
	}
}
