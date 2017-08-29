using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;
	
	void OnTriggerEnter2D(Collider2D Collider){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		print("Triggered");
		levelManager.load_level("Lose");
	}

}
