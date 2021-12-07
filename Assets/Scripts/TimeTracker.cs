using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeTracker : MonoBehaviour
{

    bool isPlaying;

    float secondsPlayed;

    public float playTimeInSeconds;

    private Text text;



public void startPlaying(){
    isPlaying = true;
    secondsPlayed = 0;
}


    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        
        Debug.LogWarning(text);

    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying && secondsPlayed < playTimeInSeconds){
            secondsPlayed += Time.deltaTime;
            Debug.Log("Seconds: " + secondsPlayed);
            text.text = "Tiempo: " + Math.Round(secondsPlayed, 1) + " s";
        }
        else{
            isPlaying = false;
        }
        
    }
}
