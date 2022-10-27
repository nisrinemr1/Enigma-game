using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelManager : MonoBehaviour
{

    System.Random rdm = new System.Random();
    public string text; //bonjour
    public List<int> textIntoAscii = new List<int>(); // liste des valeurs ascii de chaque lettres de text
    public string lettre; // nombre ascci de la lettre en cours trandsformé en string
    List<float> numbers = new List<float>(); // liste tempo pour y stocker les chiffres splités du nombre ascii de la lettre actuelle

    public GameObject cubeToInstantiate;
    private GameObject cubeInstantiated;

    public GameObject cubeAscii;
    public GameObject cubePseudoCode;


    private Color noColor = new Color32((byte)25, (byte)26, (byte)35, (byte)255);
    int rdmToRemember;

    void Start()
    {
        //text = Test.GetTextValue();
<<<<<<< HEAD
        Debug.Log($"in Unity {text}");
=======
        //Debug.Log($"in Unity {text}");
>>>>>>> 7ecf6ffd740c45966a621256a21fb7805451ae52
        //Debug.Log($"in Unity {Test.TestFlemmard()}");

        foreach (char l in text) // b o n j o u r 
        {
            textIntoAscii.Add(((int)l)); // converted to ASCII // 98 111 110 106 111 117 114 
            // Debug.Log(textIntoAscii[textIntoAscii.Count-1]);
        }
        SplitAscii();

    }

    void Update()
    {

    }

    void SplitAscii()
    {
        int i = 0;
        foreach (int asciiNumber in textIntoAscii)// boucle par lettre
        {
            lettre = textIntoAscii[i].ToString();

            foreach (char l in lettre) // boucle par chiffres splité d'une seule lettre
            {
                int n = l - '0'; // This works because each character is internally represented by a number. The characters '0' to '9' are represented by consecutive numbers, so finding the difference between the characters '0' and '2' results in the number 2.
                float nb = (float)(n == 0 ? 0.001f : n);
                numbers.Add(nb);
                Debug.Log(numbers[numbers.Count - 1]);
            }

            cubeInstantiated = Instantiate(cubeToInstantiate, Vector3.zero, Quaternion.identity);
            setCube();
            numbers.Clear();
            i++;

        }


    }

<<<<<<< HEAD
    void setCube() {
        
        //if(cubeInstantiated == cubeAscii && cubePseudoCode){

        cubeInstantiated.transform.GetChild(0).position = new Vector3(numbers[0], rdm.Next(0, 20), rdm.Next(-20, 20));
=======
    void setCube()
    {
        cubeInstantiated.transform.position = new Vector3(numbers[0], rdm.Next(0, 20), rdm.Next(-20, 20));
>>>>>>> 7ecf6ffd740c45966a621256a21fb7805451ae52
        cubeInstantiated.transform.GetChild(0).localScale = new Vector3(rdm.Next(1, 3), numbers[1], rdm.Next(1, 3));
        if (numbers.Count > 2)
        {
            Color32 color = new Color32();
            rdmToRemember = rdm.Next(15, 25);
            color.r = (byte)(rdm.Next(0, 255));
            color.g = (byte)(rdm.Next(0, 255));
            color.b = (byte)(numbers[2] * rdmToRemember);

            cubeInstantiated.transform.GetChild(0).GetComponent<Renderer>().material.color = color;
        }
        else
        {
            cubeInstantiated.transform.GetChild(0).GetComponent<Renderer>().material.color = noColor;
        }
        //}

    }

}
