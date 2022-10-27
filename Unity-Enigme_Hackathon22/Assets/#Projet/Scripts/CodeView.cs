using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeView : MonoBehaviour
{
    public GameObject codeViewUI;

    void Start() {

    }


    public void PushToViewCode()
    {
        
        if(codeViewUI.activeInHierarchy == true){
            codeViewUI.SetActive(false);
            

        }
        else codeViewUI.SetActive(true);
    }


}






