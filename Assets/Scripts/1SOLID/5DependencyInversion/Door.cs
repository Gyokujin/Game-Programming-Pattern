using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, ISwitchable
{
    private bool isActive;
    public bool IsActive => isActive;

    public void Activate()
    {
        Debug.Log("The door is open.");
    }

    public void Deactivate()
    {
        Debug.Log("The door is closed.");
    }
}
