using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameObject collided = collision.gameObject;
        Debug.Log("Entra");
        
        if(collided.CompareTag("Piso"))
        {
            Debug.Log("Entra a destroy");
            Destroy(this.gameObject);
        }
    }

}
