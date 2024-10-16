using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Attack Type")]
    private BaseAttack baseAttack;
    private MagicAttack magicAttack;
    private SpecialAttack specialAttack;

    [Header("Player")]
    [SerializeField]
    private PlayerAttack[] attackablePlayer;

    void Awake()
    {
        baseAttack = GetComponent<BaseAttack>();
        magicAttack = GetComponent<MagicAttack>();
        specialAttack = GetComponent<SpecialAttack>();
    }

    void Start()
    {
        foreach (PlayerAttack player in attackablePlayer)
        {
            int attackType = Random.Range(0, 3);

            switch (attackType)
            {
                case 0:
                    player.SetAttackType(baseAttack);
                    break;

                case 1:
                    player.SetAttackType(magicAttack);
                    break;

                case 2:
                    player.SetAttackType(specialAttack);
                    break;
            }

            player.Attack();
        }
    }
}