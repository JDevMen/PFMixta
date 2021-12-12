using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePointsUi : MonoBehaviour
{
    public PointSystem pointSystem;

    // Update is called once per frame
    void Update()
    {
        Text text = gameObject.GetComponent<Text>();
        text.text = "Puntaje: " + pointSystem.getNumCollissions().ToString();

    }
}
