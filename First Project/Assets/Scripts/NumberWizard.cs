using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //Declare 2 Integer Variables
    int max;
    int min;
    int guess;

    void NextGuess()
    {
        print("Is the Number BIGGER or SMALLER than " + guess + "?");

        print("PRESS UP if Number is BIGGER");
        print("PRESS DOWN if Number is SMALLER");
        print("PRESS ENTER if Number is GUESSED");
    }

    void StartGame()
    {
        //Output to Console
        max = 1001;
        min = 1;
        guess = 500;
        print("Welcome to Number Wizard");
        //Debug.Log has the same function as the Print
        Debug.Log("Please choose a Number from " + min + " to " + max);
        NextGuess();
    }

    // Use this for initialization
    void Start () {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("UP PRESSED");
            min = guess;
            guess = (max + min) / 2;
            NextGuess();
        }

        else
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("DOWN PRESSED");
            max = guess;
            guess = (max + min) / 2;
            NextGuess();
        }

        else
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("ENTER PRESSED");
            print("NUMBER GUESSED");

            print("(P)lay Again or (Q)uit?");


            if (Input.GetKeyDown(KeyCode.P))
            {
                StartGame();
            }

            else

            if (Input.GetKeyDown(KeyCode.Q))
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }

    }
}