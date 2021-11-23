using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDisparo : MonoBehaviour
{
    public float tiempoParaDesactivar;
    private float tiempoContado;

    // Start is called before the first frame update
    void Start()
    {
        tiempoContado = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoContado >= tiempoParaDesactivar)
        {
            tiempoContado = 0f;
            gameObject.SetActive(false);
        }
        else
        {
            tiempoContado += Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //cuando choque con lo que sea se desactiva
        tiempoContado = 0f;
        gameObject.SetActive(false);
    }
}

