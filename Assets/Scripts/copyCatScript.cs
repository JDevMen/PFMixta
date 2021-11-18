using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyCatScript : MonoBehaviour
{
    public GameObject camara;
    public GameObject cabeza;

    // Update is called once per frame
    void Update()
    {
        float posY = cabeza.transform.position.y;
        float posX = camara.transform.position.x;
        float posZ = camara.transform.position.z;
        Vector3 newPos = new Vector3(posX, posY, posZ);

        camara.transform.position = newPos;
    }
}
