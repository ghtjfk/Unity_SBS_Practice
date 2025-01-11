using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public float speed = 5.0f; // �̵� �ӵ�
    public float range = 10.0f; // �̵� ���� (-range ~ range)

    void Update()
    {
        // x�� ��ġ�� -range�� range ���̷� �̵�
        float xPosition = Mathf.PingPong(Time.time * speed, range * 2) - range;
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
    }
}
