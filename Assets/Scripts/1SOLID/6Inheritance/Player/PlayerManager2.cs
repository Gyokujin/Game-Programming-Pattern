using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager2 : MonoBehaviour
{
    [Header("Attack Type")]
    [SerializeField]
    private BaseAttack baseAttack;
    [SerializeField]
    private MagicAttack magicAttack;
    [SerializeField]
    private SpecialAttack specialAttack;

    [Header("Player")]
    [SerializeField]
    private PlayerAttack player;

    public void BaseAttackCommand()
    {
        player.SetAttackType(baseAttack);
        player.Attack();
    }

    public void MagicAttackCommand()
    {
        player.SetAttackType(magicAttack);
        player.Attack();
    }

    public void SpecialAttackCommand()
    {
        player.SetAttackType(specialAttack);
        player.Attack();
    }
}