using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeView : MonoBehaviour
{

    public GameObject codeViewUI;
    public Transform cube; 

    void Start() {

        //positionner le boutton par rapport au cube (on doit le faire par rapport à son anchored position)
        ((RectTransform)transform).anchoredPosition = cube.position;


    }


    public void PushToViewCode()
    {
        
        if(codeViewUI.activeInHierarchy == true){
            codeViewUI.SetActive(false);
            

        }
        else codeViewUI.SetActive(true);
    }


}






