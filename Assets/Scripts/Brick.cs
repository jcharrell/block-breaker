using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;
	
	private int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
		maxHits = hitSprites.Length + 1;
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		if(this.tag == "breakable") {
			HandleHits ();
		}
	}
	
	void HandleHits() {
		++this.timesHit;
		
		if(this.timesHit >= maxHits) {
			Destroy(gameObject);
		} else {
			LoadSprites();
		}
	}
	
	void LoadSprites() {
		int spriteIndex = timesHit - 1;
		
		// If a sprite is not defined at the index, do not attempt to use it
		if(hitSprites[spriteIndex]) {
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
