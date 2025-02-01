using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    public delegate void MyDelegate(string message);
    
    void PrintMessage(string message)
    {
        Debug.Log(message);
    }

    private void Start()
    {
        MyDelegate myDelegate = PrintMessage;

        myDelegate("����Ƽ���� ��������Ʈ��!!~");
        myDelegate("��������Ʈ�� �̷� �ž�?");
    }
}
