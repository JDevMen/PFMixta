using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    GameObject initialBall;
    bool gameStarted = false;

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (!gameStarted && collision.gameObject == initialBall)
        {
            initialBall.GetComponent<Rigidbody>().useGravity = true;

        }
    }
}
