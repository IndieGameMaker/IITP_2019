using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Transform[] playerPoints;
    public GameObject player;

    void Start()
    {
        playerPoints = GameObject.Find("PlayerSpawn").GetComponentsInChildren<Transform>();
        int idx = Random.Range(1, playerPoints.Length); // (1, 7) --> 1,2,3,4,5,6
        Instantiate(player, playerPoints[idx].position, playerPoints[idx].rotation);
    }

}
