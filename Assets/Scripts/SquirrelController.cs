/*Author's name: Elise Tang
 * last Modified by: Elise Tang
 * Date Last Modified: Oct 20, 2017
 * Program description: Main Squirrel Control
 * Revision Histroy: version 1: update object move left to right
 * 					versoion 2: update object move up to down
 * 
 * All code below it reference to class lab COMP3064 F2017 week 3  to week 6 by Przemyslaw Pawluk
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelController : MonoBehaviour {
	[SerializeField]
	private float speed = 5f; //5 float 
	[SerializeField]
	private float upY;
	[SerializeField]
	private float downY;
	[SerializeField]
	private float leftX;
	[SerializeField]
	private float rightx;

	//private variable 
	private Transform _transform; //Position, rotation and scale of an object.
	private Vector2 _currenPos;   //X and Y, current positon of the object in 2D 

	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		_currenPos = _transform.position; //get current position of the object 
		
	}
	
	// Update is called once per frame
	void Update () {
		
		_currenPos = _transform.position;

		float userInput = Input.GetAxis ("Vertical");

		if(Input.GetKey(KeyCode.LeftArrow)){
			//if left arrow is pressed move left 

			_currenPos -= new Vector2 (speed, 0); //-left
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			//if left arrow is pressed move right 

			_currenPos += new Vector2 (speed, 0); //+right
		}

		if(Input.GetKey(KeyCode.DownArrow)){
			//if left arrow is pressed move down 

			_currenPos -= new Vector2 (0,speed); //-down
		}

		if(Input.GetKey(KeyCode.UpArrow)){
			//if left arrow is pressed move up

			_currenPos += new Vector2 (0,speed); //+up
		}

		CheckBounds ();

		//apply change
		_transform.position = _currenPos;
		
	}

	//function to check squirrel is not out of bounds
	private void CheckBounds(){

		if (_currenPos.x < leftX) {
		
			_currenPos.x = leftX;
		}

		if (_currenPos.x > rightx) {

			_currenPos.x = rightx;
		}


		if (_currenPos.y > upY) {

			_currenPos.y = upY;
		}

		if (_currenPos.y < downY) {

			_currenPos.y = downY ;
		}
			
	}
}
