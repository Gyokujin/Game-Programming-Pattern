using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private string itemName;
    private int price;

    public void Init(string _itemName, int _price)
    {
        itemName = _itemName;
        price = _price;
    }

    public string GetItemName()
    {
        return itemName;
    }

    public int GetPrice()
    {
        return price;
    }
}