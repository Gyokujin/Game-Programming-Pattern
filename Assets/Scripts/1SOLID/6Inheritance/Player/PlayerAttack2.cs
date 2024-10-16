using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack2 : MonoBehaviour
{
    private IAttackType attackType;

    public PlayerAttack2(IAttackType _attackType)
    {
        SetAttackType(_attackType);
    }

    public void SetAttackType(IAttackType _attackType)
    {
        attackType = _attackType;
    }

    public void Attack()
    {
        attackType.Attack();
    }
}