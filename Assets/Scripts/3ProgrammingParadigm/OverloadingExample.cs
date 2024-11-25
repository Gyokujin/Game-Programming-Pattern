using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Person
{
    public void Eat(string a)
    {
        Debug.Log("I eat " + a);
    }

    public void Eat(string a, string b)
    {
        Debug.Log("I eat " + a + " and " + b);
    }
}

public class OverloadingExample : MonoBehaviour
{
    void Start()
    {
        Person person = new Person();
        person.Eat("apple");
        person.Eat("tomato", "phodo");
    }
}