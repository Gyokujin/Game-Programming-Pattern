using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralExample : MonoBehaviour
{
    string myName;
    int age;

    void Start()
    {
        Init();
        Run();
        Stop();
    }

    void Init()
    {
        myName = "Sally";
        age = 15;
    }

    void Run()
    {
        Debug.Log(myName + '(' + age + ')' + "∞° ¥ﬁ∏≥¥œ¥Ÿ!");
    }

    void Stop()
    {
        Debug.Log(myName + '(' + age + ')' + "∞° ∏ÿ√‰¥œ¥Ÿ!");
    }
}