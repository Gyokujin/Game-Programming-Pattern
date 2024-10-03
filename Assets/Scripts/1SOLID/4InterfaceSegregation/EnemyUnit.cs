using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour, IDamageable, IMovable2, IUnitStats
{
    public float MaxHealth { get; set; }
    public float Health { get; set; }
    public float Strength { get; set; }
    public float Dexterity { get; set; }
    public float Endurance { get; set; }
    public float Defense { get; set; }
    public float MoveSpeed { get; set; }
    public float Acceleration { get; set; }

    void Awake()
    {
        Init();
    }

    void Init()
    {
        MaxHealth = 100;
        Health = MaxHealth;
        Strength = 15;
        Dexterity = 5;
        Endurance = 6;
        Defense = 6;
        MoveSpeed = 5;
        Acceleration = 2;
    }

    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            GoForward();
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            Reverse();
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            TurnLeft();
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            TurnRight();
        else if (Input.GetKeyDown(KeyCode.Alpha5))
            TakeDamage();
        else if (Input.GetKeyDown(KeyCode.Alpha6))
            RestoreHealth();
    }

    public void GoForward()
    {
        Debug.Log("앞으로 " + MoveSpeed * Acceleration + "만큼 이동!");
    }

    public void Reverse()
    {
        Debug.Log("방향 전환!");
    }

    public void TurnLeft()
    {
        Debug.Log("왼쪽으로 회전!");
    }

    public void TurnRight()
    {
        Debug.Log("오른쪽으로 회전!");
    }

    public void TakeDamage()
    {
        int damage = 10 - (int)Defense;

        if (damage <= 0)
            return;

        Debug.Log(damage + "의 데미지를 입었다!");

        Health -= damage;
        Debug.Log("현재 체력 : " + Health);

        if (Health <= 0)
            Die();
    }

    public void Die()
    {
        Debug.Log("몬스터가 처치 되었습니다.");
        gameObject.SetActive(false);
    }


    public void RestoreHealth()
    {
        int restoreAmount = (int)Endurance * 5;
        Debug.Log("몬스터가 " + restoreAmount + "의 체력을 회복합니다.");

        Health = Mathf.Min(MaxHealth, Health + restoreAmount);
        Debug.Log("현재 체력 : " + Health);
    }
}