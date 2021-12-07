using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeTracker : MonoBehaviour
{

    bool isPlaying;

    float secondsPlayed;

    public float playTimeInSeconds;



void startPlaying(){
    isPlaying = true;
    secondsPlayed = 0;
}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying && secondsPlayed < playTimeInSeconds){
            secondsPlayed += Time.deltaTime;
        }
        else{
            isPlaying = false;
        }
        
    }
}
