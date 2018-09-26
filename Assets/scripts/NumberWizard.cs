using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess;



    // Use this for initialization
    void Start () {

        setGuess();
       
    }

    void setGuess()
    {
        guess = ((min + max) / 2);
        Debug.Log(guess + "? ist das d1 Number mois");
        //Start ();
    }

    void askPlayer()
    {

        // kleiner
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            //  Debug.Log("max " + max);
            setGuess();
        }

        // groeßer
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            // Debug.Log("min " + min);
            setGuess();
        }

        //gleich
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("super fresh, i hans");
        }

    }
    // Update is called once per frame
    void Update () {
     //   Debug.Log("Test");
        askPlayer();
	}
}
