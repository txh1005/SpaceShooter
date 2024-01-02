using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    [SerializeField] private float flySpeed;
    private int nextIndex = 1;
    // Start is called before the first frame update
    void Start() => transform.position = flyPath[0];

    // Update is called once per frame
    void Update()
    {
        if (flyPath == null) return;
        if (nextIndex >= flyPath.wayPoints.Length) return;
        if (transform.position != flyPath[nextIndex])
        {
            FlyToNextWayPoint();
        }
    }
    private void FlyToNextWayPoint()
  => transform.position = Vector3.MoveTowards(transform.position, flyPath[nextIndex], flySpeed * Time.deltaTime);
}
