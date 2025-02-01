using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public delegate void GameOverEvent();
    public static event GameOverEvent OnGameOver;

    void Start()
    {
        Debug.Log("PlayerController: 'G' ��ư�� ������ ���� �����Դϴ�.");
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
        Debug.Log("PlayerController: ���� ����!");
        if(OnGameOver != null)
        {
            OnGameOver();
        }
    }
}
