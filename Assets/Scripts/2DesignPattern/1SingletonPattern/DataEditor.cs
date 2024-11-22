using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEditor : MonoBehaviour
{
    void Start()
    {
        SingletonClass.instance.SetData(10);
        SingletonClass.instance.SetData(3.14f);

        SingletonClass.instance.GetData1();
        SingletonClass.instance.GetData2();
    }
}