﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	
	private Vector3 paddleToBallVector;
	private bool ballInPlay;
	
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		ballInPlay = false;
		paddleToBallVector = this.transform.position - paddle.transform.position;		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!ballInPlay) {
			// Hold the ball on the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			// If mouse button is clicked, start the game
			if (Input.GetMouseButtonDown(0)) {
				ballInPlay = true;
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		Vector2 tweak = new Vector2(Random.Range (0f, 0.2f), Random.Range (0f, 0.2f));
	
		if(ballInPlay) {
			this.rigidbody2D.velocity += tweak;
			
			if (collision.gameObject.tag != "breakable") {
				audio.Play();
			}
		}
		
	}
}
