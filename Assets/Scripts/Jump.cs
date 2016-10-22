﻿using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public float jumpSpeed = 241f;
	public float fowardSpeed = 20f;

	private Rigidbody2D body2d;
	private InputState inputState;

	// Use this for initialization
	void Awake () {
		body2d = GetComponent<Rigidbody2D>();
		inputState = GetComponent<InputState>();
	}
	
	// Update is called once per frame
	void Update () {
		if (inputState.standing)
		{
			if (inputState.actionButton)
			{
				body2d.velocity = new Vector2(transform.position.x < 0 ? fowardSpeed : 0, jumpSpeed);
			}
		}
	}
}
