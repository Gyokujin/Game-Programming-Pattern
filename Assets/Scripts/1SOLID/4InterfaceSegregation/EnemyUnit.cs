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
        Debug.Log("������ " + MoveSpeed * Acceleration + "��ŭ �̵�!");
    }

    public void Reverse()
    {
        Debug.Log("���� ��ȯ!");
    }

    public void TurnLeft()
    {
        Debug.Log("�������� ȸ��!");
    }

    public void TurnRight()
    {
        Debug.Log("���������� ȸ��!");
    }

    public void TakeDamage()
    {
        int damage = 10 - (int)Defense;

        if (damage <= 0)
            return;

        Debug.Log(damage + "�� �������� �Ծ���!");

        Health -= damage;
        Debug.Log("���� ü�� : " + Health);

        if (Health <= 0)
            Die();
    }

    public void Die()
    {
        Debug.Log("���Ͱ� óġ �Ǿ����ϴ�.");
        gameObject.SetActive(false);
    }


    public void RestoreHealth()
    {
        int restoreAmount = (int)Endurance * 5;
        Debug.Log("���Ͱ� " + restoreAmount + "�� ü���� ȸ���մϴ�.");

        Health = Mathf.Min(MaxHealth, Health + restoreAmount);
        Debug.Log("���� ü�� : " + Health);
    }
}