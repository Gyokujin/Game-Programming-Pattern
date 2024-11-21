using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeFactory : MonoBehaviour
{
    [SerializeField]
    private List<CafeMenu> menus;

    void Start()
    {
        foreach (CafeMenu menu in menus)
            menu.Drink();
    }
}