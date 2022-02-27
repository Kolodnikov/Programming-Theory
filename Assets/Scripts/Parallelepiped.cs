using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallelepiped : Figure
{
    public float width { get; private set; }
    public float height { get; private set; }
    public override float Square()
    {
        return width * height;
    }

    public override float Perimeter()
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
