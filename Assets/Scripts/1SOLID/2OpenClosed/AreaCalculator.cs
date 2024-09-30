using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCalculator : MonoBehaviour
{
    [SerializeField]
    private Shape[] shapes;

    void Start()
    {
        foreach (Shape shape in shapes)
            GetArea(shape);
    }

    public void GetArea(Shape shape)
    {
        string name = shape.ShapeName;
        float area = shape.CalculateArea();
        Debug.Log(name + "ÀÇ ³ÐÀÌ´Â " + area);
    }
}