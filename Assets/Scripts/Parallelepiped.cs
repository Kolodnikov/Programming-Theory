using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallelepiped : Figure // INHERITANCE
{
    public float width { get; private set; } // ENCAPSULATION
    public float height { get; private set; } // ENCAPSULATION

    // ABSTRACTION
    public override float Square() // POLYMORPHISM
    {
        return width * height;
    }

    // ABSTRACTION
    public override float Perimeter() // POLYMORPHISM
    {
        return width * 2 + height * 2;
    }

    private float GetWidth()
    {
        return gameObject.transform.localScale.x;
    }

    private float GetHeight()
    {
        return gameObject.transform.localScale.y;
    }

    private void Update()
    {
        width = GetWidth();
        height = GetHeight();
    }
}
