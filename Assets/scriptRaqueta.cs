using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRaqueta : MonoBehaviour
{

    private PointSystem pointSystem;

    // Start is called before the first frame update
    void Start()
    {
        pointSystem = GameObject.FindGameObjectWithTag("pointSystem").GetComponent<PointSystem>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            pointSystem.sumCollision();
            Debug.LogWarning("Detected Collission with raquet ");
            Destroy(collision.gameObject);
        }
    }
}
