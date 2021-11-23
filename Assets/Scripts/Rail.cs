using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class Rail : MonoBehaviour
{
    private Transform[] nodes;

    private void Start()
    {
        nodes = GetComponentsInChildren<Transform>();

    }

    public Vector3 LinearPos(int seg, float ratio)
    {
        Vector3 pos1 = nodes[seg].position;
        Vector3 pos2 = nodes[seg + 1].position;

        return Vector3.Lerp(pos1, pos2, ratio);
    }

    public Vector3 CatmullPos(int seg, float ratio)
    {
        Vector3 p1, p2, p3, p4;

        if (seg == 0)
        {
            p1 = nodes[seg].position;
            p2 = p1;
            p3 = nodes[seg + 1].position;
            p4 = nodes[seg + 2].position;
        }
        else if (seg == nodes.Length - 2)
        {
            p1 = nodes[seg - 1].position;
            p2 = nodes[seg].position;
            p3 = nodes[seg + 1].position;
            p4 = p3;
        }
        else
        {
            p1 = nodes[seg - 1].position;
            p2 = nodes[seg].position;
            p3 = nodes[seg + 1].position;
            p4 = nodes[seg + 2].position;
        }

        float t2 = ratio * ratio;
        float t3 = t2 * ratio;

        float x = 0.5f * ((2.0f * p2.x) + (-p1.x + p3.x) * t2 + (2.0f * p1.x - 5.0f * p2.x + 4 * p3.x - p4.x) * t2 + (-p1.x + 3.0f *));
    }

    public Quaternion Orientation(int seg, float ratio)
    {
        Quaternion q1 = nodes[seg].rotation;
        Quaternion q2 = nodes[seg + 1].rotation;

        return Quaternion.Lerp(q1, q2, ratio);
    }



    private void OnDrawGizmos()
    {
        for (int i = 0; i < nodes.Length - 1; i++)
        {
            Handles.DrawDottedLine(nodes[i].position, nodes[i + 1].position, 3f);
        }
    }
}
