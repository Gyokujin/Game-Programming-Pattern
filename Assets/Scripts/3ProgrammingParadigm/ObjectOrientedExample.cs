using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientedExample : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4, 5, 11, 12 };

    int GetMax(int[] numbers)
    {
        int max = 0;

        foreach (int num in numbers)
            max = Mathf.Max(num, max);

        return max;
    }

    void Start()
    {
        int maxNum = GetMax(numbers);
        Debug.Log(maxNum);
    }
}