using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public WayPoint[] wayPoints;
    public Vector3 this[int index] => wayPoints[index].transform.position;

    private void Reset() => wayPoints = GetComponentsInChildren<WayPoint>();
    private void OnDrawGizmos()
    {
        if (wayPoints == null) return;
        Gizmos.color = Color.green;
        for (int i = 0; i < wayPoints.Length - 1; i++)
        {
            Gizmos.DrawLine(wayPoints[i].transform.position, wayPoints[i + 1].transform.position);
        }
    }
}
