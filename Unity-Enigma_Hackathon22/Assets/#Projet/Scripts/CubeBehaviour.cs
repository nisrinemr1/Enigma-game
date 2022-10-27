using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ne pas oublier le using pour le TextmeshproUI
using TMPro;

public class CubeBehaviour : MonoBehaviour
{

    [HideInInspector] public float rotationSpeed = 50f;
    public TextMeshProUGUI transformCube;

    //Color32 va me donner en 32 bit le format rgb d'un objet
    public Color32 colorCube;
    void Start()
    {
        colorCube = gameObject.GetComponent<MeshRenderer>().material.color;
        transformCube.text = $"{transform.position}  \n {transform.localScale} \n {colorCube.r+ " "+colorCube.g+ " "+colorCube.b}";
    }
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        
        
    }

}
