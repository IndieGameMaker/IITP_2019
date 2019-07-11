using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private CharacterController cc;
    private Transform camTr;
    public float moveSpeed = 1.5f;

    public Transform firePos;  //총알이 생성될 위치
    private GameObject bullet; //Bullet 프리팹 저장할 변수
    
    void Start()
    {
        cc = GetComponent<CharacterController>();
        camTr = Camera.main.transform;
        bullet = Resources.Load<GameObject>("Bullet");
    }

    void Update()
    {
        cc.SimpleMove(camTr.forward * moveSpeed);
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            GameObject _bullet = Instantiate(bullet
                                            , firePos.position + Vector3.up * 0.02f
                                            , firePos.rotation);
            Destroy (_bullet, 5.0f);                            
        }
    }
}
