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
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed");
            // used to use up arrow 
            min = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed");
            // used to use down arrow
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit Enter");
            // used to use enter key
        }
    }

}
