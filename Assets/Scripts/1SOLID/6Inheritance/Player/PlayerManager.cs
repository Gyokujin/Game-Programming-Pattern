using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
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
    private PlayerAttack[] attackablePlayer;

    void Awake()
    {
        attackTypes = new IAttackType[] { baseAttack, magicAttack, specialAttack };
    }

    void Start()
    {
        foreach (PlayerAttack player in attackablePlayer)
        {
            int attackType = Random.Range(0, attackTypes.Length);
            player.SetAttackType(attackTypes[attackType]);
            player.Attack();
        }
    }
}