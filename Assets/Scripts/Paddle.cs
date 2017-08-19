using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	private Ball ball;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update (){
		if(!autoPlay){
			MoveWithMouse();
		}else{
			AutoPlay();	
		}
	}
	
	void MoveWithMouse(){
		float paddleWidthInUnits = this.renderer.bounds.size.x;
		float paddlePosX = Input.mousePosition.x/Screen.width * 16;
		this.transform.position = new Vector3(Mathf.Clamp(paddlePosX, paddleWidthInUnits/2, 16-paddleWidthInUnits/2) , 0.5f, 0f);
	}
	
	void AutoPlay(){
		ball = GameObject.FindObjectOfType<Ball>();
		this.transform.position = new Vector3(ball.transform.position.x, 0.5f, 0f);
	}
}
