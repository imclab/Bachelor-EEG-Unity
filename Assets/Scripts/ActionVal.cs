﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActionVal : MonoBehaviour {

	private GameObject character;
	Text text;

	void Start(){
		text = GetComponent<Text>();
		character = GameObject.Find("Player");
	}
	
	void Update () {
		text.text = character.GetComponent<InputHandler>().GetCurrentCognitivAction();
	}
}