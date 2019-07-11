using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LaserBehaviour : MonoBehaviour
{
    //이벤트 연결
    void OnEnable()
    {
        TouchMgr.OnLaserEnter += LaserEnter;
        TouchMgr.OnLaserExit  += LaserExit;
    }

    //이벤트 해지
    void OnDisable()
    {
        TouchMgr.OnLaserEnter -= LaserEnter;
        TouchMgr.OnLaserExit  -= LaserExit;
    }

    void LaserEnter(GameObject obj)
    {

    }

    void LaserExit()
    {

    }
}
