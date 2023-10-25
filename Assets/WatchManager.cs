using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchManager : MonoBehaviour
{
    float Degree = 0;
    public float SpedDegree = 1f;
    void Update()
    {
        Degree += Time.deltaTime * SpedDegree / 10f;
        Vector3 pos = Vector3.zero;
        pos.x = -Mathf.Cos(Degree * Mathf.Rad2Deg);
        pos.y = Mathf.Sin(Degree * Mathf.Rad2Deg);
        transform.position = pos * 10;
    }
}
