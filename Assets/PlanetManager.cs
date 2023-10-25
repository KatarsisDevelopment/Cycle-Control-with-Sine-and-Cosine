using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    float Degree = 0;
    public float SpedDegree = 1f;
    public bool LocalOrNot = true;
    void Update()
    {
        Degree += Time.deltaTime * SpedDegree / 10f;
        Vector3 pos = Vector3.zero;
        if (LocalOrNot)
        {
            pos.x = -Mathf.Cos(Degree * Mathf.Rad2Deg);
            pos.y = Mathf.Sin(Degree * Mathf.Rad2Deg);
            transform.position = pos * 30;
        }
        else
        {
            pos.z = -Mathf.Cos(Degree * Mathf.Rad2Deg);
            pos.y = Mathf.Sin(Degree * Mathf.Rad2Deg);
            transform.localPosition = pos * 2;
        }
    }
}
