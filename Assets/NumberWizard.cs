using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour { 
        int max = 1000;
        // sets max value to 1000
        int min = 1;
        // sets min value to 1
        int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
       

        Debug.Log("Welcome to number wizard dude");
        // Used for introduction to game
        Debug.Log("Pick an number, dont tell me what it is");
        // Tells the user basic instruction for game
        Debug.Log("The highest number you can pick is: " + max);
        // The user can not pick a number greater than 1000
        Debug.Log("The lowest number you can pick is: " + min);
        // The user can not pick a number less than 1
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        max = max + 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am so smart!");
            // used to use enter key
        }
    }

}
