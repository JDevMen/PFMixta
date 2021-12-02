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
            Debug.Log("entró a colisión con pelota");
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameStarted = true;
        }
    }
}
