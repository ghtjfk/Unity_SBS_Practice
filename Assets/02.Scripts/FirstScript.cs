using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    void Start()
    {
        print(NextYear(2025));
    }

    int NextYear(int thisYear)
    {
        int nextYear = thisYear + 1;
        return nextYear;
    }
}
