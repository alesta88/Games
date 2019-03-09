using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {



    public Color zcolor ;
    public Renderer rend;
    public float f;
    

    void Start()
    {
        Color zcolor = Color.red;
        f = 0.4f;
        
    }

    void Update()
    {
        GetComponent<Renderer>().material.color = zcolor;
        GetComponent<Renderer>().material.SetColor("_EmissionColor", zcolor * f);
    }
}


