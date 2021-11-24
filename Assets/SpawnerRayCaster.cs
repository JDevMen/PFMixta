using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnerRayCaster : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        var inputDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(inputDevices);
        Debug.Log("objeto " + inputDevices.ToString());
        foreach (var device in inputDevices)
        {
            Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
        }
        // Input.GetAxis("Right Controller Trigger");
        // Input.GetButton("");
        List<UnityEngine.XR.InputDevice> devices = new List<UnityEngine.XR.InputDevice>(); 

        UnityEngine.XR.InputDevices.GetDevicesWithRole(UnityEngine.XR.InputDeviceRole.RightHanded, devices);

        foreach (var device in devices)
        {
            UnityEngine.XR.HapticCapabilities capabilities;
            if (device.TryGetHapticCapabilities(out capabilities))
            {
                    if (capabilities.supportsImpulse)
                    {
                        uint channel = 0;
                        float amplitude = 0.5f;
                        float duration = 1.0f;
                        device.SendHapticImpulse(channel, amplitude, duration);
                    }
            }
        }
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
