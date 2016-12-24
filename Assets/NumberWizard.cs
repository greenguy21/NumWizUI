using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	//Vars
	int max, min, guess;
	int maxGuessesAllowed = 10;
	public Text guessText;

	// Use this for initialization
	void Start() {
		max = 1001;
		min = 1;
		guess = 500;
		guessText.text = guess.ToString();
	}
		
	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}
		
	void NextGuess(){
		guess = (min + max) / 2;
		guessText.text = guess.ToString();
		maxGuessesAllowed--;
		print(maxGuessesAllowed.ToString());
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
