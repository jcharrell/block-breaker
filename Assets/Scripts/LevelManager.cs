using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	private int min;
	private int max;
	public int guess;
	public string guessText;

	public void LoadLevel(string name) {
		Debug.Log("Level load requested: " + name);
		Application.LoadLevel (name);
	}
	
	public void QuitGame() {
		Debug.Log ("Quit game requested");
		Application.Quit();
	}
}
