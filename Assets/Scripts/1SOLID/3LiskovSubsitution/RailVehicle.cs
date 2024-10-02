using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailVehicle : Vehicle, IMovable
{
    public void Move(string dir)
    {
        switch (dir)
        {
            case "Front":
                GoForward();
                break;

            case "Back":
                GoBack();
                break;
        }
    }

    public void GoForward()
    {
        Debug.Log("앞으로 전진!");
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }

    public void GoBack()
    {
        Debug.Log("뒤로 후진!");
        transform.Translate(speed * Time.deltaTime * -Vector3.forward);
    }
}