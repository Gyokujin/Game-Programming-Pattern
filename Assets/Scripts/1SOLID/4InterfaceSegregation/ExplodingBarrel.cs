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

        Debug.Log(damage + "의 데미지를 입었다!");

        Health -= damage;
        Debug.Log("현재 체력 : " + Health);

        if (Health <= 0)
            Die();
    }

    public void Die()
    {
        Debug.Log("드럼통의 체력이 0이 되었습니다.\n" + FuseDelay + "초뒤 폭발합니다.");
        Invoke(nameof(Explode), FuseDelay);
        
    }

    public void Explode()
    {
        Debug.Log("드럼통이 폭발 되었습니다.\n" + Mass + "범위에 " + ExplosiveForce + "만큼 피해를 줍니다.");
        gameObject.SetActive(false);
    }

    public void RestoreHealth()
    {
        int restoreAmount = (int)MaxHealth / 5;
        Debug.Log("드럼통이 수리 되었습니다.\n" + restoreAmount + "의 체력을 회복합니다.");

        Health = Mathf.Min(MaxHealth, Health + restoreAmount);
        Debug.Log("현재 체력 : " + Health);
    }
}