using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {
    //Global Variables
    int max;
    int min ;
    int guess ;

	//Game Start
	void Start () {
        StartGame();
    }	
    
    //Game Update
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {          
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {            
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
        }
    }
    
    //Custom Functions
    void StartGame()
    {
         max = 1000;
         min = 0;
         guess = 500;
        
        print("=================================================");
        print("Welcome to Number Wizard");
        print("Please pick a number and don't tell me");

        print("The highest number you can pick is " + max + " the minimum number you can pick is " + min);
        print("Is the number higher or lower than" + guess);
        print("Up = higher, down = lower, return = equal");
        max = max + 1;
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Up = higher, down = lower, return = equals");
    }
}
