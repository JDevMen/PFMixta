using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyCatScript : MonoBehaviour
{
    // public GameObject cabeza;
    public GameObject camara;

    public GameObject rigg;

    private Vector3 lastPositionCamera;

    private Vector3 lastRotationCamera;

    public GameObject cabeza;

    int timesCalled = 0;

    string Concat(string val, Vector3 vec)
{
    return val + " (" + vec.x + ", " + vec.y + ", " + vec.z + ")";
}

    void Start(){
        cabeza.transform.position = new Vector3(cabeza.transform.position.x, camara.transform.position.y, cabeza.transform.position.z);
        lastPositionCamera = camara.transform.position;
        timesCalled++;
        Debug.Log("Times Called: " + timesCalled);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPositionCamera = camara.transform.position;
        Vector3 deltaCam = newPositionCamera - lastPositionCamera;

        Vector3 newRotationCamera = Quaternion.Normalize(camara.transform.rotation).eulerAngles;
        Vector3 deltaRotationCamera =  newRotationCamera - lastRotationCamera ;
        //  Debug.Log("Last position Cam: "+ lastPositionCamera);
        //  Debug.Log("New position Ca: "+ newPositionCamera);
         Debug.Log(Concat("Delta: ", deltaCam));
        Debug.Log("Last rotation Cam: "+ lastRotationCamera);
         Debug.Log("New rotaiton Cam: "+ newRotationCamera);
         Debug.Log(Concat("Delta Rotation: ", deltaRotationCamera));
        //  Debug.Log("Delta 2: "+ (Vector3.Subtraction()));

        gameObject.transform.Translate( deltaCam.x, deltaCam.y, deltaCam.z, Space.World);
        // cabeza.transform.rotation = camara.transform.rotation;
        // cabeza.transform.Rotate(new Vector3(0, deltaRotationCamera.y, deltaRotationCamera.z), Space.World);
        cabeza.transform.Rotate(deltaRotationCamera, Space.World);
        // gameObject.transform.Rotate(new Vector3(deltaRotationCamera.x, 0, 0), Space.World);

        Debug.Log(Concat("Actual Translation: ", deltaCam * Time.deltaTime*50));

        lastPositionCamera = newPositionCamera;
        lastRotationCamera = newRotationCamera;
        // float posY = camara.transform.position.y;
        // float posX = cabeza.transform.position.x;
        // float posZ = cabeza.transform.position.z;
        // Vector3 newPos = new Vector3(posX, posY, posZ);

        // cabeza.transform.position = newPos;
        // Vector3 velocityCam = camara.GetComponent<Rigidbody>().velocity;
        // Vector3 velocityRigg = rigg.GetComponent<Rigidbody>().velocity;

        // Debug.Log("Velocity Cam: "+ velocityCam);

        // Debug.Log("Velocity Rigg: "+ velocityRigg);

        // Debug.Log("Position camara: "+ camara.transform.position);
        // Debug.Log("Position rigg: "+ rigg.transform.position);
    }

    void FixedUpdate(){
        // Debug.Log()
        // gameObject.GetComponent<Rigidbody>().velocity = camara.GetComponent<Rigidbody>().velocity;
    }
}
