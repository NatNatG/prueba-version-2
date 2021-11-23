using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparador : MonoBehaviour
{
    public float velocidadDisparo;

    private Pooling mPooling;

    // Start is called before the first frame update
    void Start()
    {
        // todas las armas estaran asignadas, pero hay que deshabilitarlas, excepto una
        mPooling = GetComponent<Pooling>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject copiaDisparo = mPooling.GetObjetoDelPool();

            if(copiaDisparo)
            {
                copiaDisparo.transform.position = transform.position + transform.forward;
                copiaDisparo.transform.rotation = transform.rotation;
                copiaDisparo.GetComponent<Rigidbody>().AddForce(transform.forward * velocidadDisparo, ForceMode.VelocityChange);
            }
        }

        
    }
    /*if (Input.GetButtonDown("LB"))
    {
        int nuevaArma = (armaSeleccionada - 1) < 0 ? Armas.Count - 1 ? : armaSeleccionada - 1;
            nuevaArma = nuevaArma % Armas.Count;
        ActivarArma(nuevaArma);
    }
    else if (Input.GetButtonDown("RB"))
    {
        int nuevaArma = (armaSeleccionada + 1) % Armas.Count;
        ActivarArma(nuevaArma);
    }*/


    /*private void ActivarArma(int indiceArma)
    {
        Armas[armaSeleccionada].SetActive(false);

        Armas[indiceArma].SetActive(true);

        armaSeleccionada = indiceArma;
    }*/
}