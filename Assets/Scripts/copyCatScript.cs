using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyCatScript : MonoBehaviour
{
    public GameObject cabeza;
    public GameObject camara;

    // Update is called once per frame
    void Update()
    {
        float posY = camara.transform.position.y;
        float posX = cabeza.transform.position.x;
        float posZ = cabeza.transform.position.z;
        Vector3 newPos = new Vector3(posX, posY, posZ);

        cabeza.transform.position = newPos;
    }
}
