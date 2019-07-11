using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TouchMgr : MonoBehaviour
{
    //레이저가 들어갔을 때 호출 이벤트 원형을 델리게이트로 선언
    public delegate void LaserEnterHandler(GameObject obj);
    public static event LaserEnterHandler OnLaserEnter;

    //레이저가 나갔을 때 호출할 이벤트의 원형을 선언
    public delegate void LaserExitHandler();
    public static event LaserExitHandler OnLaserExit;

    private Ray ray;
    private RaycastHit hit;
    
    //현재 응시하고 있는 버튼
    private GameObject currButton;

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
            OnLaserExit(); //Exit 이벤트 발생
            OnLaserEnter(hit.collider.gameObject); //Enter 이벤트 발생

            currButton = hit.collider.gameObject;
        }
        else
        {
            OnLaserExit();
            currButton = null;
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && currButton != null)
        {
            PointerEventData data = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(currButton, data, ExecuteEvents.pointerClickHandler);
        }
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("Play", LoadSceneMode.Single);
    }
}
