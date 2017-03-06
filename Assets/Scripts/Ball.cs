using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool ballInPlay;
	
	// Use this for initialization
	void Start () {
		ballInPlay = false;
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(!ballInPlay) {
			// Hold the ball on the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			// If mouse button is clicked, start the game
			if(Input.GetMouseButtonDown(0)) {
				ballInPlay = true;
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
			}
		}
	}
}
