using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectGeneratorScript : MonoBehaviour
{
    public GameObject objectGenerated;

    public float timeBetweenGenerations = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateObject(timeBetweenGenerations));
    }

    IEnumerator generateObject(float sec)
    {

        while (true)
        {
        yield return new WaitForSeconds(sec);
        Instantiate(objectGenerated, this.transform.position, Quaternion.identity);

        }

    }
}
