using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadVehicle : Vehicle, ITurnable, IMovable
{
    public float roationSpeed = 1;

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

            case "Left":
                TurnLeft();
                break;

            case "Right":
                TurnRight();
                break;
        }
    }

    public void GoForward()
    {
        Debug.Log("������ ����!");
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }

    public void GoBack()
    {
        Debug.Log("�ڷ� ����!");
        transform.Translate(speed * Time.deltaTime * -Vector3.forward);
    }

    public void TurnLeft()
    {
        Debug.Log("�������� ȸ��!");
        Quaternion targetRotation = Quaternion.Euler(0, -90, 0) * transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * roationSpeed);
    }

    public void TurnRight()
    {
        Debug.Log("���������� ȸ��!");
        Quaternion targetRotation = Quaternion.Euler(0, 90, 0) * transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * roationSpeed);
    }
}