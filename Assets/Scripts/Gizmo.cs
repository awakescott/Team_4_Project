using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmo : MonoBehaviour
{
    // Set Variables
    public Color color = new Color(0.985f, 0.022f, 0.022f, 0.2f);
    public List<GameObject> targets = new List<GameObject>();
    public Vector3 size = new Vector3(1, 1, 0);

    void OnDrawGizmos()
    {
        // Draw the gizmos their appropriate colour in the desired position
        Gizmos.color = color;
        Gizmos.DrawCube(transform.position, size);

        // If the targets are more than 0, add one and draw a line for the gizmo
        if (targets.Count > 0)
        {
            for (int i = 0; i < targets.Count; i++)
            {
                Gizmos.DrawLine(transform.position, targets[i].transform.position);
            }
        }

    }

    public GameObject GetRandomTarget()
    {
        // If the target count is 0, return null
        if (targets.Count == 0)
            return null;

        // Return a random number between 0 and the target count
        return targets[Random.Range(0, targets.Count)];
    }

    public GameObject GetTargetAt(int index)
    {
        // If the target count is 0, return null
        if (targets.Count == 0)
            return null;

        // Return targets from the index
        return targets[index];
    }
}
