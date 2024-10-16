using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicAttack : MonoBehaviour, IAttackType
{
    public void Attack()
    {
        Debug.Log("Magic Attack");
    }
}