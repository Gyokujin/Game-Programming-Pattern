using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public float MaxHealth { get; set; }
    public float Health { get; set; }
    public float Defense { get; set; }

    public void Die();
    public void TakeDamage();
    public void RestoreHealth();
}