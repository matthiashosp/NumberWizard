using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess;

    void setGuess()
    {
        guess = ((min + max) / 2);
        Debug.Log("guess " + guess);
    }

    // Use this for initialization
    void Start () {

        setGuess();
       
        // kleiner
        if (false)
        {
            max = guess;
            Debug.Log("max " + max);
        }

        // groeßer
        if (true)
        {
            min = guess;
            Debug.Log("min " + min);
        }

        //gleich
        if (false){
        Debug.Log("gefunden ");
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
