using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mayoriadeedad : MonoBehaviour
{
    public int edad;
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        if (edad >= 18)
        {
            texto.text = "usted es mayor de edad";
            Debug.Log("usted es mayor de edad");
        }

        else
        {
            texto.text = "usted es menor de edad";
            Debug.Log("usted es menor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
