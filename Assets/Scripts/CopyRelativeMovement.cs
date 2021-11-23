using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRelativeMovement : MonoBehaviour
{

    public GameObject objectToCopy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.localPosition = objectToCopy.transform.localPosition;

    }
}
