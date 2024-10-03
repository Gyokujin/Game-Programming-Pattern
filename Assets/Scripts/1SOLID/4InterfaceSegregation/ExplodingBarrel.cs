using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingBarrel : MonoBehaviour, IDamageable, IExplodable
{
    public float MaxHealth { get; set; }
    public float Health { get; set; }
    public float Defense { get; set; }
    public float Mass { get; set; }
    public float ExplosiveForce { get; set; }
    public float FuseDelay { get; set; }

    void Awake()
    {
        Init();
    }

    void Init()
    {
        MaxHealth = 20;
        Health = MaxHealth;
        Defense = 4;
        Mass = 2;
        ExplosiveForce = 30;
        FuseDelay = 2;
    }

    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            TakeDamage();
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            RestoreHealth();
    }

    public void TakeDamage()
    {
        int damage = 15 - (int)Defense;

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
        Debug.Log("�巳���� ü���� 0�� �Ǿ����ϴ�.\n" + FuseDelay + "�ʵ� �����մϴ�.");
        Invoke(nameof(Explode), FuseDelay);
        
    }

    public void Explode()
    {
        Debug.Log("�巳���� ���� �Ǿ����ϴ�.\n" + Mass + "������ " + ExplosiveForce + "��ŭ ���ظ� �ݴϴ�.");
        gameObject.SetActive(false);
    }

    public void RestoreHealth()
    {
        int restoreAmount = (int)MaxHealth / 5;
        Debug.Log("�巳���� ���� �Ǿ����ϴ�.\n" + restoreAmount + "�� ü���� ȸ���մϴ�.");

        Health = Mathf.Min(MaxHealth, Health + restoreAmount);
        Debug.Log("���� ü�� : " + Health);
    }
}