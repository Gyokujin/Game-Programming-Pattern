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
        Debug.Log("로봇 스위치 ON");
    }

    public void Deactivate()
    {
        IsActive = false;
        Debug.Log("로봇 스위치 OFF");
    }

    public override void FindPath()
    {
        Debug.Log(moveSpeed + " 속도로 경로 이동");
    }

    public override void CollectResources()
    {
        Debug.Log(searchRadius + "미터 반경 내의 적을 탐색");
    }
}