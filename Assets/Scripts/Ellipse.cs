using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse : Figure
{

    public float radiusX { get; private set; }
    public float radiusY { get; private set; }

    public override float Square()
    {
        return Mathf.PI * radiusX * radiusY;
    }

    public override float Perimeter()
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
