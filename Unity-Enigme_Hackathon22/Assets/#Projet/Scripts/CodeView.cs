using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeView : MonoBehaviour
{
    public GameObject codeViewUI;
    private GameObject mainCamera;

    void Start() {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Update(){
        
        transform.LookAt(mainCamera.transform.position);
        Debug.DrawRay(transform.position, transform.forward,Color.red);
        transform.parent.forward = mainCamera.transform.position;
    }


    public void PushToViewCode()
    {
        
        if(codeViewUI.activeInHierarchy == true){
            codeViewUI.SetActive(false);
            

        }
        else codeViewUI.SetActive(true);
    }


}






