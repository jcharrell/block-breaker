using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;
	public static int breakableCount = 0;
	public AudioClip crack;
	
	private bool isBreakable;
	private int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "breakable");
		
		if(isBreakable) {
			breakableCount++;
		}
		
		timesHit = 0;
		maxHits = hitSprites.Length + 1;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		AudioSource.PlayClipAtPoint (crack, transform.position, .1f);
		if(this.tag == "breakable") {
			HandleHits ();
		}
	}
	
	void HandleHits() {
		++this.timesHit;
		
		if(this.timesHit >= maxHits) {
			breakableCount--;
			Destroy(gameObject);
			levelManager.CheckWinCondition();
		} else {
			LoadSprites();
		}
	}
	
	void LoadSprites() {
		int spriteIndex = timesHit - 1;
		
		// If a sprite is not defined at the index, do not attempt to use it
		if(hitSprites[spriteIndex]) {
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		} else {
			Debug.LogError ("Brick sprite missing");
		}
	}
}
