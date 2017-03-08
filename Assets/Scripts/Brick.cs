using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		++this.timesHit;
		
		if(this.timesHit == this.maxHits) {
			GameObject.Destroy (this.gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
