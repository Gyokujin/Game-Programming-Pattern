using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverEditor : MonoBehaviour
{
    void Start()
    {
        Topic topic = new Topic();

        TopicSubscriber a = new TopicSubscriber();
        a.Init("a", topic);

        TopicSubscriber b = new TopicSubscriber();
        b.Init("b", topic);

        TopicSubscriber c = new TopicSubscriber();
        c.Init("c", topic);

        topic.Register(a);
        topic.Register(b);
        topic.Register(c);

        topic.PostMessage("amumu is op champion!!");
    }
}