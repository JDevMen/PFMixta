using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rail rail;

    private int currentSeg;

    private float transition;

    private bool isCompleted;

    private void Start()
    {
        if (!rail)
        {
            Debug.Log("Entró a no hay riel");
            return;
        }

        if (!isCompleted)
            Play();
    }

    private void Play()
    {
        transition += Time.deltaTime * 1 / 2.5f;

        if (transition > 1)
        {
            transition = 0;
            currentSeg++;
        }
        else if (transition < 0)
        {
            transition = 1;
            currentSeg--;
        }

        transform.position = rail.LinearPos(currentSeg, transition);
        transform.rotation = rail.Orientation(currentSeg, transition);
    }

}
