using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    bool gameStarted = false;




    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Entr� a colisi�n");

        if (!gameStarted && collision.gameObject.tag == "Ball")
        {
            Debug.Log("entr� a colisi�n con pelota");
            collision.rigidbody.useGravity = true;
            gameStarted = true;
        }
    }
}
