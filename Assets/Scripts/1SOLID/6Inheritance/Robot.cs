using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Robot : MonoBehaviour
{
    protected float moveSpeed = 4;
    protected float searchRadius = 3;

    public abstract void FindPath();
    public abstract void CollectResources();
}