using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput), typeof(PlayerMovement), typeof(PlayerAudio))]
public class Player : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerMovement playerMovement;
    private PlayerAudio playerAudio;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerMovement = GetComponent<PlayerMovement>();
        playerAudio = GetComponent<PlayerAudio>();
    }

    public class PlayerInput : MonoBehaviour
    {

    }

    public class PlayerMovement : MonoBehaviour
    {

    }

    public class PlayerAudio : MonoBehaviour
    {

    }
}