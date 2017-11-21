/*Author's name: Elise Tang
 * last Modified by: Elise Tang
 * Date Last Modified: Oct 20, 2017
 * Program description: Main Squirrel Control
 * Revision Histroy: version 1: update user screen
 * 
 * All code below it reference to class lab COMP3064 F2017 week 3  to week 6 by Przemyslaw Pawluk
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //enable to use UI elements
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	// making it [serializeField] so designer can controll it in unity 
	// so it is public in unity 
	[SerializeField]
	Text lifeLabel;
	[SerializeField]
	Text scoreLabel;
	[SerializeField]
	Text gameOverLabel;
	[SerializeField]
	Text highScoreLabel;
	[SerializeField]
	Button resetBtn;
	[SerializeField]
	Button startBtn;



	private int _score = 0;
	private int _lifes =3;


	public int Score{
		//using getter and setter to update the UI 
		get{ return _score;}
		set{_score = value;
			//update the value in UI text
			scoreLabel.text = "Score: " + _score;
			Debug.Log ("Score is:"+_score);
		}

	}

	public int Life{


		get{ return _lifes;}
		set{ _lifes = value;

			//check if the life is equals to zero if it is game over 
			if(_lifes <= 0){
				//called gameOver(); to update the Screen 
				gameOver();

			}else{
				lifeLabel.text = "Lifes: " + _lifes;
			}
		}


	}

	//this funciton will make the lables disappreal
	private void initialize(){
		Score = 0;
		Life = 3;

		//when set it to false it will not show on the screen 
		gameOverLabel.gameObject.SetActive (false);
		resetBtn.gameObject.SetActive (false);

		//when set it to false it will show on the screen 
		lifeLabel.gameObject.SetActive (true);
		scoreLabel.gameObject.SetActive (true);

	}

	private void gameOver(){
		gameOverLabel.gameObject.SetActive (true);
		resetBtn.gameObject.SetActive (true);

		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
	
	
	}
	// Use this for initialization
	void Start () {

		//start with initialize();		
		initialize ();
	}

	public void StartGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	
	}

	//connect to reset button to restart the game 
	public void ResetGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

}
