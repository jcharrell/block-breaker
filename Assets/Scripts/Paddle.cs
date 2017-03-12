using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;
	private Ball ball;
	Vector3 paddlePos;
	float mousePosInBlocks;
	
	void Start() {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse();
		}	else {
			AutoPlay();
		}
	}
	
	void MoveWithMouse() {
		mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		
		paddlePos = new Vector3(Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f), this.transform.position.y, this.transform.position.z);
		this.transform.position = paddlePos;
	}
	
	void AutoPlay() {
		paddlePos = new Vector3(Mathf.Clamp (ball.transform.position.x, 0.5f, 15.5f), this.transform.position.y, this.transform.position.z);
		this.transform.position = paddlePos;
	}
}
