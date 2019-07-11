using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Transform[] playerPoints;
    private GameObject player;
    private GameObject enemy;

    public float createTime = 5.0f;
    public bool isGameOver = false;

    void Start()
    {
        //Resources 폴더에 있는 Player, Enemy 프리팹을 로드
        player = Resources.Load<GameObject>("Player");
        enemy  = Resources.Load<GameObject>("Enemy");

        //PlayerSpawn 포인트를 배열에 추가
        playerPoints = GameObject.Find("PlayerSpawn").GetComponentsInChildren<Transform>();
        //랜덤한 위치 추출
        int idx = Random.Range(1, playerPoints.Length); // (1, 7) --> 1,2,3,4,5,6
        //주인공 캐릭터 생성
        Instantiate(player, playerPoints[idx].position, playerPoints[idx].rotation);

        StartCoroutine(this.CreateEnemey());
    }
    
    IEnumerator CreateEnemey()
    {
        while(!isGameOver)
        {
            yield return new WaitForSeconds(createTime); //5초 마다 한번씩 
            int idx = Random.Range(1, playerPoints.Length);
            Instantiate(enemy
                        , playerPoints[idx].position
                        , playerPoints[idx].rotation);
        }
    }

}
