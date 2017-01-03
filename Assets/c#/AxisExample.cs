using UnityEngine;
using System.Collections;

public class AxisExample : MonoBehaviour {

	public float range;
	public GUIText textOutput;
	
	// Update is called once per frame
	void Update() {
		float h = Input.GetAxis("Horizontal");
		float xPos = h * range;

		transform.position = new Vector3(xPos, 2f, 0);
		textOutput.text = "Value returned: " + h.ToString("F2");
	}
}
