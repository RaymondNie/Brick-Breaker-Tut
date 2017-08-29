using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void load_level(string name){
		Debug.Log("Level load requested for " + name);
		Application.LoadLevel(name);
	}
	
	public void quit_level(){
		Debug.Log("Quit level");
		Application.Quit();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1); // Loads next level of build sequence
	}
	
}
