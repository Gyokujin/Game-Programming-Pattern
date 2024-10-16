using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackType
{
    public enum AttackType
    {
        Base, Magic, Special
    }

    public void Attack();
}