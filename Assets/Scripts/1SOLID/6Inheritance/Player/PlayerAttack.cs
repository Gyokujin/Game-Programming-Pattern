using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private IAttackType attackType;

    public void SetAttackType(IAttackType _attackType)
    {
        attackType = _attackType;
    }

    public void Attack()
    {
        attackType.Attack();
    }
}