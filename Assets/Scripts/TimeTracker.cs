using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeTracker : MonoBehaviour
{

    bool isPlaying= false   ;

    bool stoppedPlaying = false;

    float secondsPlayed;

    public float playTimeInSeconds;

    private Text text;

public GameObject objectGenerator;

public Canvas canvasExterno;

public GameObject puntajeFinalTxt;

public PointSystem pointSystem;

GameObject intro;

GameObject playButton;

GameObject rePlayButton;

public GameObject manoIzquierda;

public void startPlaying(){
    isPlaying = true;
    stoppedPlaying = false;
    secondsPlayed = 0;

    objectGenerator.SetActive(true);

    intro.SetActive(false);
    playButton.SetActive(false);
    LineRenderer line = manoIzquierda.GetComponent<LineRenderer>();
    Debug.LogWarning(line);
    line.enabled= !enabled;

        manoIzquierda.transform.Find("raquetaDerecha").gameObject.SetActive(true);

}




    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        
        Debug.LogWarning(text);

        intro =  canvasExterno.gameObject.transform.Find("Intro").gameObject;

        playButton =  canvasExterno.gameObject.transform.Find("Button").gameObject;

        rePlayButton = canvasExterno.gameObject.transform.Find("volverButton").gameObject;

       
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlaying && !stoppedPlaying && secondsPlayed < playTimeInSeconds){
            secondsPlayed += Time.deltaTime;
            Debug.Log("Seconds: " + secondsPlayed);
            text.text = "Tiempo: " + Math.Round(secondsPlayed, 1) + " s";
        }
        else if(isPlaying && secondsPlayed >= playTimeInSeconds){
            isPlaying = false;
            stoppedPlaying = true;
        }
        if(stoppedPlaying){
            objectGenerator.SetActive(false);
            puntajeFinalTxt.SetActive(true);
            puntajeFinalTxt.GetComponent<Text>().text = "Felicidades, tu puntaje final fue: "+ pointSystem.getNumCollissions();
            rePlayButton.SetActive(true);

           LineRenderer line = manoIzquierda.GetComponent<LineRenderer>();
    Debug.LogWarning(line);
    line.enabled= !enabled;

            manoIzquierda.transform.Find("raquetaDerecha").gameObject.SetActive(false);
        }
        // else{

        //     Debug.LogWarning("Entró a else termino juego");

        //     objectGenerator.SetActive(false);
        //     puntajeFinalTxt.SetActive(true);
        //     // puntajeFinalTxt.GetComponent<Text>().text = "Felicidades, tu puntaje final fue: "+ pointSystem.getNumCollissions();
        // }
        
    }

    public void replay(){


        SceneManager.LoadScene("2ndPOV");
    }
}
