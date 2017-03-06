using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	Vector3 paddlePos;
	float mousePosInBlocks;
	
	// Update is called once per frame
	void Update () {		
		mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		
		paddlePos = new Vector3(Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f), this.transform.position.y, this.transform.position.z);
		this.transform.position = paddlePos;
	}
}
