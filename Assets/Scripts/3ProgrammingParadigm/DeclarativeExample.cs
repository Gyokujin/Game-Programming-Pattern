using System;
using System.Collections.Generic;
using UnityEngine;

public class DeclarativeExample : MonoBehaviour
{
    int Add(int x, int y)
    {
        return x + y;
    }

    List<int> Map(List<int> numbers, Func<int, int> func)
    {
        List<int> result = new List<int>();

        foreach (var number in numbers)
            result.Add(func(number));

        return result;
    }

    void Start()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Func<int, int> addTwo = x => Add(x, 2);
        List<int> result = Map(numbers, addTwo);

        foreach (int number in result)
            Debug.Log(number);
    }
}