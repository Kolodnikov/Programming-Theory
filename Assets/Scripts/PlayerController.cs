using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float ScaleRate = 0.05f;
    private float highBound = 4;
    private float lowBound = 0.1f;

    // Update is called once per frame
    void Update()
    {
        float h_input = Input.GetAxis("Horizontal");
        float v_input = Input.GetAxis("Vertical");
        if (h_input != 0 || v_input != 0)
        {
            ScaleObject(h_input, v_input);
            CheckBounds();
        }
    }

    private void ScaleObject(float hScale, float vScale)
    {
        gameObject.transform.localScale += new Vector3(hScale * ScaleRate, vScale * ScaleRate, 0);
    }

    private void CheckBounds()
    {
        float hScale = gameObject.transform.localScale.x;
        float vScale = gameObject.transform.localScale.y;

        if (hScale > highBound)
        {
            hScale = highBound;
        }
        if (hScale < lowBound)
        {
            hScale = lowBound;
        }

        if (vScale > highBound)
        {
            vScale = highBound;
        }
        if (vScale < lowBound)
        {
            vScale = lowBound;
        }

        gameObject.transform.localScale = new Vector3(hScale, vScale, 1);
    }

}
