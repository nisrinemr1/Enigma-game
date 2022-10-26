using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeView : MonoBehaviour
{

    public GameObject codeViewUI;
    public void PushToViewCode()
    {
        codeViewUI.SetActive(true);
        //codeViewUI.SetActive(false);
    }
}






