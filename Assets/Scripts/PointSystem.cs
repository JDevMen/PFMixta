using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    // Start is called before the first frame update
    private int numberOfCollissions = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            numberOfCollissions++;
            Debug.Log("Detected Collission: " + numberOfCollissions);
        }
    }

    public int getNumCollissions()
    {
        return numberOfCollissions;
    }

}
