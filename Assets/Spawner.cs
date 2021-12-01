using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Crea objeto");
        //Instantiate(objectToSpawn);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Crea objeto en el update");
            //Vector3 pos = Input.mousePosition;
            //Debug.Log(pos.x + "," + pos.y + "," + pos.z);
            //Instantiate(objectToSpawn, pos, Quaternion.identity);
        }
    }

    // public void Click()
    // {
    //     Debug.Log("Click");
    // }

    // public void CreateObjectPing()
    // {
    //     Debug.Log("Crea objeto con click");
    //     Vector3 mousePos = Input.mousePosition;
    //     Instantiate(objectToSpawn, mousePos, Quaternion.identity);
    // }
}
