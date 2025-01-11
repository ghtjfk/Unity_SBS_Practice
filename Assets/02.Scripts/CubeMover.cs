using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public float speed = 5.0f; // 이동 속도
    public float range = 10.0f; // 이동 범위 (-range ~ range)

    void Update()
    {
        // x축 위치를 -range와 range 사이로 이동
        float xPosition = Mathf.PingPong(Time.time * speed, range * 2) - range;
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
    }
}
