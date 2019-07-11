using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCtrl : MonoBehaviour
{
    private Transform laserTr;
    private LineRenderer line;
    private Ray ray;
    private RaycastHit hit;

    //기본 레이저 길이
    public float maxDistance = 10.0f;

    void Start()
    {
        laserTr = GetComponent<Transform>();
        line    = GetComponent<LineRenderer>();
    }

    void Update()
    {
        ray = new Ray(laserTr.position, laserTr.forward);
        if (Physics.Raycast(ray , out hit, maxDistance))
        {
            line.SetPosition(1, new Vector3(0,0,hit.distance));
        }
        else
        {
            line.SetPosition(1, new Vector3(0, 0, maxDistance));
        }        
    }
}
