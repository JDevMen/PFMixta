using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoSeguimiento : MonoBehaviour
{

    public GameObject cabeza;

    private Vector3 lastRotationCabeza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cabezaPosition = cabeza.transform.position;
        gameObject.transform.position = new Vector3(cabezaPosition.x, cabezaPosition.y - 0.8f, cabezaPosition.z);

        Vector3 deltaRotationCabeza =  cabeza.transform.rotation.eulerAngles - lastRotationCabeza ;

        gameObject.transform.Rotate(0, deltaRotationCabeza.y, 0);

        lastRotationCabeza = cabeza.transform.rotation.eulerAngles;
        
        
    }
}
