using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text IngresoUsuario;
    public Text textoMsj;
    public GameObject msjError;
    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "123123";
        msjError.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasenia ()
    {
        contraseniaUsuario = IngresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            textoMsj.text = "bienvenido";
            msjError.SetActive(true);
            Debug.Log("bienvenido");
        }
        else
        {
            textoMsj.text = "contraseña incorrecta";
            msjError.SetActive(true);
            Debug.Log("contraseña incorrecta");
        }
    }
}
