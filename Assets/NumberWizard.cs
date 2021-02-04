using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int minNum;
    int maxNum;
    int myGuess;
    // Start is called before the first frame update
    void Start()
    {
        IntroStart();
    }
    void IntroStart()
    {
        maxNum = 1000;
        minNum = 1;
        myGuess = 500;
        Debug.Log("....Cue the Theme Music...");
        Debug.Log("Welcome to Number Wizard - the magical number guessing game! ");
        Debug.Log("Choose a number that is no less than " + minNum + " and no more than " + maxNum);
        Debug.Log("Tell me if your number is higher or lower than my guess of " + myGuess);
        Debug.Log("Push Up Arrow = higher number, Push Down Arrow = lower number, Push Enter = correct number!");
        maxNum += 1;
    }
        // Update is called once per frame
    void Update()
    {
        LowerGuess();
        HigherGuess();
        CorrectGuess();
    }
    void LowerGuess()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNum = myGuess;
            NextGuess();
        }
    }
    void HigherGuess()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNum = myGuess;
            NextGuess();
        }
    }
    void CorrectGuess()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("||========================||");
            Debug.Log("||////////////////////////||");
            Debug.Log("|| I'm magically correct! ||");
            Debug.Log("||\\\\\\\\\\\\\\\\\\\\\\\\||");
            Debug.Log("||========================||");
            IntroStart();
        }
    }
    void NextGuess() 
    {
        myGuess = (minNum + maxNum) / 2;
        Debug.Log("Is your number higher or lower than " + myGuess + "?");
    }
}
