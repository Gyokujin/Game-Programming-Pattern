using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigator : MonoBehaviour
{
    public RoadVehicle car;
    public RailVehicle train;

    void Update()
    {
        KeyInput();
    }

    void KeyInput()
    {
        if (Input.GetKey(KeyCode.W))
            Command("Front");
        else if (Input.GetKey(KeyCode.S))
            Command("Back");

        if (Input.GetKey(KeyCode.A))
            Command("Left");
        else if (Input.GetKey(KeyCode.D))
            Command("Right");
    }

    void Command(string command)
    {
        car.Move(command);
        train.Move(command);
    }
}