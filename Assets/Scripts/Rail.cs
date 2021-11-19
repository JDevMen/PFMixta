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
