using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneControl : MonoBehaviour
{
    public void CambiarAEscena(int numeroEscena)
    {
        SceneManager.LoadScene(numeroEscena);
    }

    public void CambiarAEscena(string numeroEscena)
    {
        SceneManager.LoadScene(numeroEscena);
    }

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Opciones.gameObject.SetActive(true);
        }
    }*/

}
