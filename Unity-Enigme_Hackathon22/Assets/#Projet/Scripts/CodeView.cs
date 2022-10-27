using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeView : MonoBehaviour
{
    public GameObject codeViewUI;
    private GameObject mainCamera;
    private Vector3 betweenBoxPlayer;
    public CubeBehaviour cube;
    private Canvas canva;

    private float extendMax = 0f;


    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        canva = transform.parent.GetComponent<Canvas>();
        canva.worldCamera = mainCamera.GetComponent<Camera>();
    }
    void Update()
    {
        transform.LookAt(mainCamera.transform.position); // orientation du boutton
        transform.parent.LookAt(mainCamera.transform.position); // orientation du plane dataCube

        Debug.DrawRay(transform.position, transform.forward, Color.red);

        float newExtendMax = Mathf.Max(cube.cubeCollider.bounds.extents.x, cube.cubeCollider.bounds.extents.y, cube.cubeCollider.bounds.extents.z);
        extendMax = Mathf.Max(newExtendMax, extendMax);
        betweenBoxPlayer = (mainCamera.transform.position - cube.transform.position).normalized;
        transform.position = cube.transform.position + (betweenBoxPlayer * extendMax) + transform.forward * 0.5f; //position du boutton
        transform.Rotate(Vector3.up, 180);
    }



    public void PushToViewCode()
    {
        Debug.Log("qierughliuergmh");
        if (codeViewUI.activeInHierarchy == true)
        {
            codeViewUI.SetActive(false);
        }
        else codeViewUI.SetActive(true);
    }


    void OnDrawGizmos()
    {
        Color color = Color.cyan;
        color.a = 0.25f;
        Gizmos.color = color;
        Gizmos.DrawWireCube(cube.cubeCollider.bounds.center, Vector3.one * extendMax * 2);
        Gizmos.DrawCube(cube.cubeCollider.bounds.center, Vector3.one * extendMax * 2);
    }



}






