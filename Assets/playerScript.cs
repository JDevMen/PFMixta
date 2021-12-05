using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    bool gameStarted = false;




    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Entró a colisión");

        if (!gameStarted && collision.gameObject.tag == "Ball")
        {
            Debug.Log("entró a colisión con pelota");
            collision.rigidbody.useGravity = true;
            gameStarted = true;
        }
    }
}
