using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopicSubscriber : Observer
{
    private string name;
    private Subject topic;

    public void Init(string name, Subject topic)
    {
        this.name = name;
        this.topic = topic;
    }

    public void Update()
    {
        string msg = topic.GetUpdate().ToString();
        Debug.Log(name + ":: got message >> " + msg);
    }
}