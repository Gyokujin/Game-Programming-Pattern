using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CafeMenu : MonoBehaviour
{
    protected string menuName;

    void Awake()
    {
        Init();
    }

    public abstract void Init();

    public virtual string GetName()
    {
        return menuName;
    }

    public virtual void SetName(string name)
    {
        menuName = name;
    }

    public virtual void Drink()
    {
        Debug.Log(menuName + "¸¦ ¸¶¼Ì´Ù.");
    }
}