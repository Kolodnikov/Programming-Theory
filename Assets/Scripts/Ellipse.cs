using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse : Figure // INHERITANCE
{

    public float radiusX { get; private set; } // ENCAPSULATION
    public float radiusY { get; private set; } // ENCAPSULATION

    // ABSTRACTION
    public override float Square() // POLYMORPHISM
    {
        return Mathf.PI * radiusX * radiusY;
    }

    // ABSTRACTION
    public override float Perimeter() // POLYMORPHISM
    {
        return Mathf.PI * Mathf.Sqrt(2 * (radiusX * radiusX + radiusY * radiusY));
    }

    private float GetRadiusX()
    {
        return gameObject.transform.localScale.x / 2;
    }

    private float GetRadiusY()
    {
        return gameObject.transform.localScale.y / 2;
    }

    private void Update()
    {
        radiusX = GetRadiusX();
        radiusY = GetRadiusY();
    }
}
