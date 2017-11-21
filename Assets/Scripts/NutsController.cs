using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutsController : MonoBehaviour {

	//made the nuts down in ramdon place 
	//how?
	//1. set the frame range 
	//2. let it appreal in that range 
	[SerializeField]
	private float startY = 3439;
	[SerializeField]
	private float endY = -3463;
	[SerializeField]
	private float startX = -1892;
	[SerializeField]
	private float endX = 4360;

	//private variables
	private Transform _transform; 
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		Reset ();

	}
		
	//place the nuts in random place to collect points
	public void Reset(){

		_transform.position = new Vector2 (Random.Range(startX, endX),Random.Range(startY,endY));
	}
}
