using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Benz : Car
{
   
    void Start()
    {
        modelName = "Benz";
        year = 2022;
        isAccident = false;
        MoveForward();
    }

   
    void Update()
    {
        
    }
}
