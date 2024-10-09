using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Robot, ISwitchable
{
    public bool IsActive { get; set; }

    void Awake()
    {
        Activate();
        FindPath();
        CollectResources();
        Deactivate();
    }

    public void Activate()
    {
        IsActive = true;
        Debug.Log("�κ� ����ġ ON");
    }

    public void Deactivate()
    {
        IsActive = false;
        Debug.Log("�κ� ����ġ OFF");
    }

    public override void FindPath()
    {
        Debug.Log(moveSpeed + " �ӵ��� ��� �̵�");
    }

    public override void CollectResources()
    {
        Debug.Log(searchRadius + "���� �ݰ� ���� ���� Ž��");
    }
}