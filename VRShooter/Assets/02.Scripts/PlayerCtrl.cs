using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private CharacterController cc;
    private Transform camTr;
    public float moveSpeed = 1.5f;
    
    void Start()
    {
        cc = GetComponent<CharacterController>();
        camTr = Camera.main.transform;
    }

    void Update()
    {
        cc.SimpleMove(camTr.forward * moveSpeed);
    }
}
