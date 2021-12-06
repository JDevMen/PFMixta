using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Vector3 prevBallposition;

    void Start()
    {
        prevBallposition = gameObject.transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject collided = collision.gameObject;
        Debug.Log("Entra collision");
        Debug.Log(collided.tag);

        //if(collided.tag == "Raqueta")
        //{
        //    Debug.Log("Entra collision raq. VeL:" + collision.relativeVelocity);
        //    Debug.Log("Contact point: " + collision.GetContact(0).point);
        //    gameObject.GetComponent<Rigidbody>().AddForceAtPosition(collision.GetContact(0).normal * collision.relativeVelocity.magnitude * 10, collision.GetContact(0).point);

        //    gameObject.GetComponent<Rigidbody>().useGravity = true;
        //    //gameObject.GetComponent<Rigidbody>().addForce
        //}

        if (collided.CompareTag("Piso"))
        {
            Debug.Log("Entra a destroy");
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(prevBallposition, gameObject.transform.position, out hit))
        {
            if (hit.collider.tag == "Raqueta")
            {
                Debug.Log("Raycast hit: " + hit.transform.position);
                gameObject.transform.position = hit.transform.position;
            }

        }




        prevBallposition = gameObject.transform.position;
    }

}
