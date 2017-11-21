/*Author's name: Elise Tang
 * last Modified by: Elise Tang
 * Date Last Modified: Oct 20, 2017
 * Program description: Main Squirrel Control
 * Revision Histroy: verson 1: make backgroud moving left to right 
 * 
 * All code below it reference to class lab COMP3064 F2017 week 3  to week 6 by Przemyslaw Pawluk
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassFiledController : MonoBehaviour {

	// making it [serializeField] so designer can controll it in unity 
	// so it is public in unity 
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;


	//private variable 
	private Transform _transform; //Position, rotation and scale of an object.
	private Vector2 _currenPos;   //X and Y, current positon of the object 


	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> (); //get object position, ratation and scale 
		_currenPos = _transform.position; //get the current position from _transform using .position method 

		Reset ();
	}

	// Update is called once per frame
	void Update () {
		//making the sky moving left to right 
		_currenPos = _transform.position; //get current position 
		_currenPos -= new Vector2(speed, 0); //-down +up (x,Y) moving in x 

		//check if current object positon 
		if(_currenPos.x < endX){
			Reset ();
		}
		_transform.position = _currenPos; //apply it to object
	}

	//to reset x 
	//this function will call in two place
	//start() to make sure it start in correct position 
	//update() 
	private void Reset(){
		
		_currenPos = new Vector2 (startX, 0);

	}
}
