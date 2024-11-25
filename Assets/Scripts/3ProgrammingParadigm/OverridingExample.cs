using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Animal
{
    public virtual void Bark()
    {
        Debug.Log("mumu! mumu!");
    }
}

class Dog : Animal
{
    public override void Bark()
    {
        Debug.Log("wal!!! wal!!!");
    }
}

public class OverridingExample : MonoBehaviour
{
    void Start()
    {
        Animal animal = new Animal();
        animal.Bark();

        Dog dog = new Dog();
        dog.Bark();
    }
}