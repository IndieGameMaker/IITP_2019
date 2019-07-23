using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TouchMgr : MonoBehaviour
{
    public GameObject placerModel;
    public ARRaycastManager raycastMgr;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            if (raycastMgr.Raycast(touch.position
                                    , hits
                                    , TrackableType.PlaneWithinPolygon))
            {
                Vector3 pos = hits[0].pose.position + hits[0].pose.up * 0.01f;
                Instantiate(placerModel, pos, hits[0].pose.rotation);
            }
        }
    }
}
