using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttack : MonoBehaviour, IAttackType
{
    public void Attack()
    {
        Debug.Log("Base Attack");
    }
}