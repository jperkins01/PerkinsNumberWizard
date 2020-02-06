using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number wizard dude");
        // Used for introduction to game
        Debug.Log("Pick an number, dont tell me what it is");
        // Tells the user basic instruction for game
        Debug.Log("The highest number you can pick is 1000");
        // The user can not pick a number greater than 1000
        Debug.Log("The lowest number you can pick is 1");
        // The user can not pick a number less than 1
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
