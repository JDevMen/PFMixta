using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRelativeMovement : MonoBehaviour
{
    
    private GameObject anchorObject;
    private GameObject objectToCopy;
    public string anchorTag;
    public string objtectToCopyTag;
    // Start is called before the first frame update

    public GameObject parentObject;
    void Start()
    {
        anchorObject = GameObject.FindWithTag(anchorTag);
        objectToCopy = GameObject.FindWithTag(objtectToCopyTag);

    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = parentObject.transform.position + (objectToCopy.transform.position - anchorObject.transform.position);
        gameObject.transform.eulerAngles = parentObject.transform.eulerAngles + (objectToCopy.transform.eulerAngles - anchorObject.transform.eulerAngles);
        gameObject.transform.eulerAngles = gameObject.transform.eulerAngles + new Vector3(0, 0, 1) * 90;

    }
}
