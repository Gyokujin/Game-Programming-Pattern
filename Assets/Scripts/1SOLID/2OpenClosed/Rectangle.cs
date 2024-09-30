using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Shape
{
    public override string ShapeName { get; set; } = "Rectangle";
    public float width;
    public float height;

    public override float CalculateArea()
    {
        return width * height;
    }
}