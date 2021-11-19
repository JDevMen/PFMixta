using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRayCaster : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // var inputDevices = new List<UnityEngine.XR.InputDevice>();
        // UnityEngine.XR.InputDevices.GetDevices(inputDevices);
        // Debug.Log(inputDevices);
        // UnityEngine.XR.Input
        // foreach (var device in inputDevices)
        // {
        //     Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
        // }
        // Input.GetAxis("Right Controller Trigger");
        Input.GetButton("Primary (sandwich button)(1)");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.Log(ray);
            bool ans = Physics.Raycast(ray, out hit, 10000);
            if (ans)
            {
                Input.GetAxis("Right Controller Trigger");
                GameObject.Find("RightHand Controller");
                Debug.Log(hit.collider.name + ", " + hit.point);
                Debug.Log("mouse position " + Input.mousePosition);
                if (hit.collider.name=="Plane") 
                    Instantiate(objectToSpawn, hit.point, Quaternion.identity);
            }
        }
    }
}
