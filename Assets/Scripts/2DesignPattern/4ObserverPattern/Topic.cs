using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topic : Subject
{
    private List<Observer> observers = new List<Observer>();
    private string message;

    public void Register(Observer obj)
    {
        if (!observers.Contains(obj))
            observers.Add(obj);
    }

    public void Unregister(Observer obj)
    {
        observers.Remove(obj);
    }

    public void NotifyObservers()
    {
        foreach (Observer obj in observers)
            obj.Update();
    }

    public object GetUpdate()
    {
        return message;
    }

    public void PostMessage(string msg)
    {
        Debug.Log("Message sended to Topic: " + msg);
        message = msg;
        NotifyObservers();
    }
}