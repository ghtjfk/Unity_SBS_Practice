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

        myDelegate("유니티에서 델리게이트를!!~");
        myDelegate("델리게이트가 이런 거야?");
    }
}
