using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAttack : MonoBehaviour, IAttackType
{
    public void Attack()
    {
        Debug.Log("Special Attack");
    }
}