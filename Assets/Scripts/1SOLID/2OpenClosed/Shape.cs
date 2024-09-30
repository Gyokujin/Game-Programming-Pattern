using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public abstract string ShapeName { get; set; }
    public abstract float CalculateArea();
}