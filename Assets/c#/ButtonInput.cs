﻿using UnityEngine;
using System.Collections;

public class ButtonInput : MonoBehaviour {

	public GUITexture graphic;
	public Texture2D standard;
	public Texture2D downgfx;
	public Texture2D upgfx;
	public Texture2D heldgfx;
	
	// Use this for initialization
	void Start() {
		graphic.texture = standard;
	}
	
	// Update is called once per frame
	void Update() {
		bool down = Input.GetButtonDown("Jump");
		bool held = Input.GetButton("Jump");
		bool up = Input.GetKeyDown("Jump");
		
		if(down) {
			graphic.texture = downgfx;
		}else if(held) {
			graphic.texture = heldgfx;
		}else if(up) {
			graphic.texture = upgfx;
		}else {
			graphic.texture = standard;
		}
		
//		GUIText.text = " " + down + "\n " + held + "\n " + up;
	}
}
