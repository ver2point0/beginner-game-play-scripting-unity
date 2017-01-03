using UnityEngine;
using System.Collections;

public class DualAxisExample : MonoBehaviour {

	public float range;
	public GUIText textOutput;
	
	// Update is called once per frame
	void Update() {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		float xPos = h * range;
		float yPos = v * range;
		
		transform.position = new Vector3(xPos, yPos, 0);
		textOutput.text = "Horizonal Value returned: " + h.ToString("F2") + "\nVertical Value returned: " + v.ToString("F2");
	}
}
