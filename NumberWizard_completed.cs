using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	int max;
	int min;
	int guess;
	// Use this for initialization
	void Start() {		
		StartGame();
	}
	
	void StartGame() {
		max = 1000;
		min = 0;
		guess = 500;
		
		print("###############################################");
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me!");
		
		print("The the highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);
		
		print("Is the number higher or lower than " + guess + " ?" );
		print("Down = lower, Up = higher, Return/Enter = equal");
	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess +1;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I Won!");
			Restart();
		}
	}
	
	void NextGuess() {
		guess = (max + min)/2;
		print ("Higher or lower than: " + guess + " ?");
		print("Down = lower, Up = higher, Return/Enter = equal");
	}
	
	void Restart () {
		StartGame();
	}
	
}
