using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int hp = 90;

    private void Start()
    {
        Debug.Log(2 < 5);
        Debug.Log(5 == 5);
        Debug.Log(6 == 5);
        Debug.Log(7 != 5);
        Debug.Log(7 != 7);
        Debug.Log(3 <= 5);
        Debug.Log(3 <= 3);
        Debug.Log(4 >= 4);
        Debug.Log(2 >= 4);
    }
}