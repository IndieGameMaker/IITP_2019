using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TouchMgr : MonoBehaviour
{
    public GameObject placerModel;
    public ARRaycastManager raycastMgr;
    private List<ARRaycastHit> hits;

    void Start()
    {
        placerModel = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        placerModel.transform.localScale = Vector3.one * 0.1f;
        placerModel.AddComponent<Rigidbody>();
    }

    void Update()
    {
        //터치가 되지 않으면 리턴
        if (Input.touchCount == 0) return;

        //첫번째 터치의 정보 저장
        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            if (raycastMgr.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
            {
                Vector3 pos = hits[0].pose.position + hits[0].pose.up * 0.3f;
                Instantiate(placerModel,pos, hits[0].pose.rotation);
            }
        }
    }
}
