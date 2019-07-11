#define TEST
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Navigation 관련 네임스페이스

public class EnemyCtrl : MonoBehaviour
{
    //컨트롤할 컴포넌트 변수 선언
    private Transform enemyTr;
    private Transform playerTr;
    private NavMeshAgent nv;
    private Animator anim;
    //적캐릭터의 사망여부
    private bool isDie = false;
    //적캐릭터의 HP
    private float hp = 100.0f;

    void Start()
    {
        //초기화 (변수 값을 할당 (Assign), 대입)
        enemyTr     = GetComponent<Transform>();
        playerTr    = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        nv          = GetComponent<NavMeshAgent>();
        anim        = GetComponent<Animator>();
    }

    void Update()
    {
        if (isDie)
        {
            this.enabled = false; //스크립트를 비활성화
        }
        #if TEST
        playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        #endif

        nv.SetDestination(playerTr.position);
        nv.isStopped = false;   
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {
            //총알 삭제
            Destroy(coll.gameObject);

            hp -= 10.0f;
            if (hp <= 0.0f)
            {
                EnemyDie();
            }
        }
    }

    void EnemyDie()
    {
        Debug.Log("Enemy Die");
        Destroy(this.gameObject, 3.0f);
    }
}
