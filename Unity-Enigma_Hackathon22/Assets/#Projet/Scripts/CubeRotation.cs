using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{

[HideInInspector] public float rotationSpeed = 50f;
    public Space mySpace;

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, mySpace);

    }
}
