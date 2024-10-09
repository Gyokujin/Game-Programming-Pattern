using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, ISwitchable
{
    public bool IsActive { get; set; }

    public void Activate()
    {
        IsActive = true;
        Debug.Log("The door is open.");
    }

    public void Deactivate()
    {
        IsActive = false;
        Debug.Log("The door is closed.");
    }
}
