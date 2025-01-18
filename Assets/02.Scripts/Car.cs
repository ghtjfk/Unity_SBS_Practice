using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public string modelName;
    public int year;
    public bool isAccident;

    public void MoveForward()
    {
        print("전진");
    }
    public void MoveBackward()
    {
        print("후진");
    }
    public void MoveStop()
    {
        print("브레이크");
    }
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
