using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager3 : MonoBehaviour
{
    [Header("Attack Type")]
    private IAttackType[] attackTypes;

    [SerializeField]
    private BaseAttack baseAttack;
    [SerializeField]
    private MagicAttack magicAttack;
    [SerializeField]
    private SpecialAttack specialAttack;

    [Header("Player")]
    [SerializeField]
    private PlayerAttack2 player;

    void Awake()
    {
        attackTypes = new IAttackType[] { baseAttack, magicAttack, specialAttack };
    }

    public void PlayerSpawn()
    {
        int attackType = Random.Range(0, attackTypes.Length);
        PlayerAttack2 spawnPlayer = new(attackTypes[attackType]);
        spawnPlayer.Attack();
    }
}