/*Author's name: Elise Tang
 * last Modified by: Elise Tang
 * Date Last Modified: Oct 20, 2017
 * Program description: Main Squirrel Control
 * Revision Histroy: version 1: making object moving right to left 
 * 					version 2: making objects show on ramdon place in the frame
 * 
 * All code below it reference to class lab COMP3064 F2017 week 3  to week 6 by Przemyslaw Pawluk
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSquirrelController : MonoBehaviour {

	//made the ememy squirrel show up in ramdon place 
	//how?
	//1. set the frame range 
	//2. let it appreal in that range 

	[SerializeField]
	private float minXSpeed = 10f;
	[SerializeField]
	private float maxXSpeed = 10f;
	[SerializeField]
	private float minYSpeed = 10f;
	[SerializeField]
	private float maxYSpeed = 10f;

	[SerializeField]
	private float startY = 2993;
	[SerializeField]
	private float endY = -2772 ;
	[SerializeField]
	private float startX =-2417;
	[SerializeField]
	private float endX = 4607 ;

	private Transform _transform;
	private Vector2 _currentSpeed; //set the speed inside the script 
	private Vector2 _currentPosition;

	//only use when the game start 
	void Start () {
		
		//_currentSpeed = new Vector2 (10, 0); //current speed of the object
		_transform = gameObject.GetComponent<Transform> ();
		Reset ();
	}

	public void Reset(){

		//made random speed 
		float xSpeed = Random.Range(minXSpeed,maxXSpeed); 
		float ySpeed = Random.Range (minYSpeed, maxYSpeed);

		//current speed 
		_currentSpeed = new Vector2 (xSpeed, ySpeed);

		//current position
		//make it random
		_transform.position = new Vector2 (Random.Range(startX,endX), Random.Range(startY,endY)); 

	}


	// Update is called once per frame
	void Update () {
		
		_currentPosition = _transform.position; //where is the object now 
		_currentPosition -= _currentSpeed; //where we want it to be 
		_transform.position = _currentPosition; //apply now position 

	
		if (_currentPosition.x <= -4771) {
			Reset ();
		}

	}


}
