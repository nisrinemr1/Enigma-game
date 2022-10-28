using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    // Start is called before the first frame update
    private Material mat;

    public levelManager colorCollect; 
    void Start()
    {
        mat = new Material(GetComponent<Renderer>().material);
        GetComponent<Renderer>().material = mat;
        // mat.SetColor("_EmissionColor", colorCollect.);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
