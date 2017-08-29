using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	
	// Used for game boundary
	private float xMin;
	private float xMax;
	private float yMin;
	private float yMax;
	private float playerWidth;
	private float playerHeight;
	
	// Use this for initialization
	void Start () {
		xMin = Camera.main.ViewportToWorldPoint(new Vector3(0f,0f,0f)).x;
		xMax = Camera.main.ViewportToWorldPoint(new Vector3(1f,0f,0f)).x;
		yMin = Camera.main.ViewportToWorldPoint(new Vector3(0f,0f,0f)).y;
		yMax = Camera.main.ViewportToWorldPoint(new Vector3(0f,1f,0f)).y;
		
		playerWidth  = (float)renderer.bounds.size.x;
		playerHeight = (float)renderer.bounds.size.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.position += new Vector3(0f,speed,0f);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.position += new Vector3(0f,-speed,0f);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.position += new Vector3(-speed,0f,0f);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.position += new Vector3(speed,0f,0f);
		}

		
		float newX = Mathf.Clamp(transform.position.x, xMin + playerWidth/2, xMax - playerWidth/2);
		float newY = Mathf.Clamp(transform.position.y, yMin + playerHeight/2, yMax - playerHeight/2);
		transform.position = new Vector3(newX, newY, 0f);		
	}
}
