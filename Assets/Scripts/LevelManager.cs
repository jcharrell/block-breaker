using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name) {
		Debug.Log("Level load requested: " + name);
		Application.LoadLevel (name);
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void CheckWinCondition() {
		if(Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
	public void QuitGame() {
		Debug.Log ("Quit game requested");
		Application.Quit();
	}
}
