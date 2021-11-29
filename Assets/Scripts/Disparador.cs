using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Disparador : MonoBehaviour
{
    public float velocidadDisparo;

    private Pooling mPooling;
    private Transform muzzle1;

    // Start is called before the first frame update
    void Start()
    {
        // todas las armas estaran asignadas, pero hay que deshabilitarlas, excepto una
        mPooling = GetComponent<Pooling>();
        muzzle1 = transform.Find("muzzle1");
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject copiaDisparo = mPooling.GetObjetoDelPool();

            if(copiaDisparo)
            {

                /*copiaDisparoLeft.transform.position = LeftMuzzle.position;
                copiaDisparoRight.transform.position = RightMuzzle.position;

                copiaDisparoLeft.transform.rotation = transform.rotation;
                copiaDisparoRight.transform.rotation = transform.rotation;
                copiaDisparoLeft.GetComponent<Rigidbody>().velocity = transform.parent.forward * velocidadDisparo;
                copiaDisparoRight.GetComponent<Rigidbody>().velocity = transform.parent.forward * velocidadDisparo;*/


                copiaDisparo.transform.position = muzzle1.position;
                copiaDisparo.transform.rotation = muzzle1.rotation;
                copiaDisparo.GetComponent<Rigidbody>().velocity = transform.parent.forward * velocidadDisparo;

                //SFX
                AudioManager.instancia.PlaySFX(0);
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