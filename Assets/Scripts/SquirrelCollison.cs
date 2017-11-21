/*Author's name: Elise Tang
 * last Modified by: Elise Tang
 * Date Last Modified: Oct 20, 2017
 * Program description: Main Squirrel Control
 * Revision Histroy: version 1: display on console screen 
 * 					version 2: update life and score 
 * 					version 3: update sound effect
 * 
 * All code below it reference to class lab COMP3064 F2017 week 3  to week 6 by Przemyslaw Pawluk
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelCollison : MonoBehaviour {

	[SerializeField]
	GameController gameController;
	[SerializeField]
	GameObject explosion;



	public void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.tag.Equals ("enemiesSquirrel")) {
			//Display on console 
			Debug.Log ("Conllision with enemy squirrel");

			Instantiate (explosion).GetComponent<Transform> ().position = other.gameObject.GetComponent<Transform> ().position;
			other.gameObject.GetComponent<EnemiesSquirrelController> ().Reset ();
			//reduce life in UI 
			gameController.Life -=1;


		}else if(other.gameObject.tag.Equals("Nuts")){
			//Display on console
			Debug.Log ("Conllision with nut");
			other.gameObject.GetComponent<NutsController> ().Reset ();
			//Add points to the UI 
			gameController.Score += 100;
			other.gameObject.GetComponent<AudioSource> ().Play ();
		}


	}


}
