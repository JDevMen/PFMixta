using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPositionRation : MonoBehaviour
{

    public GameObject copiedObject;
    // Start is called before the first frame update

    private Vector3 lastPositionCopied;

    private Vector3 lastRotationCopied;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPositionCopied = copiedObject.transform.position;
        Vector3 newRotationCopiead = copiedObject.transform.rotation.eulerAngles;

        Vector3 deltaPosition = newPositionCopied - lastPositionCopied;
        Vector3 deltaRotation = newRotationCopiead - lastRotationCopied;

        gameObject.transform.Translate(deltaPosition, Space.World);
        gameObject.transform.Rotate(deltaRotation, Space.World);

        lastPositionCopied = newPositionCopied;
        lastRotationCopied = newRotationCopiead;
    }
}
