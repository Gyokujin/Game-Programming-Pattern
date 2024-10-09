using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public ISwitchable client;

    void Awake()
    {
        client = GetComponent<ISwitchable>();
        Toggle();
        Toggle();
    }

    public void Toggle()
    {
        if (client.IsActive)
        {
            client.Deactivate();
        }
        else
        {
            client.Activate();
        }
    }
}