using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchMgr : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;

    public Transform laserTr;

    void Start()
    {
        
    }

    void Update()
    {
        //레이 생성
        ray = new Ray(laserTr.position, laserTr.forward);        
        if (Physics.Raycast(ray, out hit, 50.0f, 1<<8))
        {

        }
        else
        {
            
        }
    }
}
