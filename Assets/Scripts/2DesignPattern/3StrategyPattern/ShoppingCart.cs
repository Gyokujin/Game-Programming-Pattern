using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCart : MonoBehaviour
{
    private List<Item> items;

    void Start()
    {
        items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    private int CalculateTotal()
    {
        int sum = 0;

        foreach (Item item in items)
            sum += item.GetPrice();

        return sum;
    }

    public void Pay(PaymentStrategy paymentStrategy)
    {
        paymentStrategy.Pay(CalculateTotal());
    }
}