using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyCatScript : MonoBehaviour
{

    public GameObject cabeza;

    // Update is called once per frame
    void Update()
    {
        float posY = cabeza.transform.position.y;
        float posX = transform.position.x;
        float posZ = transform.position.z;
        Vector3 newPos = new Vector3(posX, posY, posZ);

        transform.position = newPos;
    }
}
