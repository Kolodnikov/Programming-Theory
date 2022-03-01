using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text txtCubeS;
    public Text txtCubeP;
    public Text txtEllipseS;
    public Text txtEllipseP;
    private Parallelepiped parallelepiped;
    private Ellipse ellipse;

    // Start is called before the first frame update
    void Start()
    {
        parallelepiped = GameObject.Find("Cube").GetComponent<Parallelepiped>();
        ellipse = GameObject.Find("Sphere").GetComponent<Ellipse>();
    }

    // Update is called once per frame
    void Update()
    {
        txtCubeP.text = "P = " + parallelepiped.Perimeter().ToString();
        txtCubeS.text = "S = " + parallelepiped.Square().ToString();
        txtEllipseP.text = "P = " + ellipse.Perimeter().ToString();
        txtEllipseS.text = "S = " + ellipse.Square().ToString();
    }

}
