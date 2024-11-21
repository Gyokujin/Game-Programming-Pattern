using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPattern2 : MonoBehaviour
{
    void Start()
    {
        SingletonPattern1.instance.SetData(10);
        SingletonPattern1.instance.SetData(3.14f);

        SingletonPattern1.instance.GetData1();
        SingletonPattern1.instance.GetData2();
    }
}