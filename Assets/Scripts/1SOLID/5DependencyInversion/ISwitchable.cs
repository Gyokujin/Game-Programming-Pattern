using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISwitchable
{
    public bool IsActive { get; set; }

    public void Activate();
    public void Deactivate();
}