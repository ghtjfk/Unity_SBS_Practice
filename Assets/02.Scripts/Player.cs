using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOver;

    void Start()
    {
        Debug.Log("PlayerController: 'G' 버튼을 누르면 게임 오버입니다.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        Debug.Log("PlayerController: 게임 오버!");
        if(OnGameOver != null)
        {
            OnGameOver();
        }
    }
}
