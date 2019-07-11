using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Transform[] playerPoints;
    private GameObject player;

    void Start()
    {
        //Resources 폴더에 있는 Player 프리팹을 로드
        player = Resources.Load<GameObject>("Player");
        //PlayerSpawn 포인트를 배열에 추가
        playerPoints = GameObject.Find("PlayerSpawn").GetComponentsInChildren<Transform>();
        //랜덤한 위치 추출
        int idx = Random.Range(1, playerPoints.Length); // (1, 7) --> 1,2,3,4,5,6
        //주인공 캐릭터 생성
        Instantiate(player, playerPoints[idx].position, playerPoints[idx].rotation);
    }

}
