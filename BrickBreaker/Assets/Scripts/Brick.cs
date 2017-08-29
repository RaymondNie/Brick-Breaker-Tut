using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
		
	private int maxHits;
	private int hitCounter;
	private LevelManager levelManager;
	
	public Sprite[] hitSprites;
	public static int brickCount = 0; // If you are setting this in the inspector then you can't
									  // initialize it in start or else it will get overwritten
	private bool isBreakable;
	public AudioClip crack;
	public GameObject smoke;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		
		// Increment the number of breakable bricks
		if(isBreakable){
			brickCount++;
		}
		
		hitCounter = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		maxHits = hitSprites.Length + 1;
		// Find total number of bricks in the level
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnCollisionEnter2D(Collision2D collision){		
		if(this.tag == "Breakable"){
			handleHits();
		}
	}
	
	void loadSprites(){
		int spriteIndex  = hitCounter - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];	
	}
	
	void handleHits(){
		int maxHits = hitSprites.Length + 1;
		hitCounter++;
		if(hitCounter >= maxHits){
			// Smoke particles
			GameObject instantiatedSmoke = Instantiate(smoke,this.transform.position,Quaternion.identity) as GameObject;
			instantiatedSmoke.particleSystem.startColor = gameObject.GetComponent<SpriteRenderer>().color;
			Destroy(instantiatedSmoke,0.5f);
			brickCount--;
			levelManager.BrickDestroyed();
			Destroy(gameObject);
		}else{
			loadSprites();
		}
	}
}
