using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	int max = 1000;
	int min = 0;
	int guess = 500;
	
	// Use this for initialization
	void Start () {		
		StartGame();
	}
	
	void StartGame () {
	  //max = max + 1; This would make max = to 1001 and print 1001 | or add it after the print statment. Check line 30
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me!");
		
		print("The the highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);
		
		print("Is the number higher or lower than " + guess + " ?" );
		print("Down = lower, Up = higher, Return/Enter = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			guess = (max + min +1)/2;
			print ("Higher or lower than: " + guess + " ?");
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			guess = (max + min)/2;
			print ("Higher or lower than: " + guess + " ?");
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I Won!");
		}
	}
}
