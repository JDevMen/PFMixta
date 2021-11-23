using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRelativeMovement : MonoBehaviour
{
    
    public GameObject anchorObject;
    public GameObject objectToCopy;
    // Start is called before the first frame update

    public GameObject parentObject;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = parentObject.transform.position + (objectToCopy.transform.position - anchorObject.transform.position);

    }
}
