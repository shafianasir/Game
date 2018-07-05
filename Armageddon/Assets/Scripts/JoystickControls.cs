using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class JoystickControls : MonoBehaviour {

	public FixedJoystick MoveJoystick;
	public FixedButton JumpButton;
	public FixedTouchField TouchField;

	void Update () {
		var fps = GetComponent<FirstPersonController>();
		fps.runAxis = MoveJoystick.inputVector;
		fps.jumpAxis = JumpButton.Pressed;
		fps.m_MouseLook.lookAxis = TouchField.TouchDist;
	}
}
