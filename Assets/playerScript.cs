using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    bool gameStarted = false;




    private void OnCollisionEnter(Collision collision)
    {
        if (!gameStarted && collision.gameObject.CompareTag("Ball"))
        {
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameStarted = true;
        }
    }
}
