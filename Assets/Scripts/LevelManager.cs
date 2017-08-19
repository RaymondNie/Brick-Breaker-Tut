using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void load_level(string name){
		Brick.brickCount = 0;
		Debug.Log("Level load requested for " + name);
		Application.LoadLevel(name);
	}
	
	public void quit_level(){
		Debug.Log("Quit level");
		Application.Quit();
	}
	
	public void LoadNextLevel(){
		Brick.brickCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1); // Loads next level of build sequence
	}
	
	public void BrickDestroyed(){
		if(Brick.brickCount <= 0){
			LoadNextLevel();
		}
	}
}
