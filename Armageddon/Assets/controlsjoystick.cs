using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class controlsjoystick : MonoBehaviour {

	public FixedJoystick MoveJoystick;
	public FixedButton JumpButton;
	public FixedTouchField TouchField;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var fps = GetComponent<RigidbodyFirstPersonController>();
		fps.moveaxis = MoveJoystick.inputVector;
		fps.jumpaixs = JumpButton.Pressed;
		fps.mouseLook.lookaxis = TouchField.TouchDist;
	}
}
