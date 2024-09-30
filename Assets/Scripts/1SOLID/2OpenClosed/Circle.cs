using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    public override string ShapeName { get; set; } = "Circle";
    public float radius;

    public override float CalculateArea()
    {
        return radius * radius * Mathf.PI;
    }
}