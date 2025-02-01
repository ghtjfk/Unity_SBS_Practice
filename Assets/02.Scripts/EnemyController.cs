using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void OnEnable()
    {
        Player.OnGameOver += RespondToGameOver;
    }

    void OnDisable()
    {
        Player.OnGameOver -= RespondToGameOver;
    }

    void RespondToGameOver()
    {
        Debug.Log("EnemyController: �÷��̾� ����. ������ �ٽ� �������.");
    }
}
