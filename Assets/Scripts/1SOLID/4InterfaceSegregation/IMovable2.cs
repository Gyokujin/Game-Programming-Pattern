using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable2
{
    public float MoveSpeed { get; set; }
    public float Acceleration { get; set; }

    public void GoForward();
    public void Reverse();
    public void TurnLeft();
    public void TurnRight();
}