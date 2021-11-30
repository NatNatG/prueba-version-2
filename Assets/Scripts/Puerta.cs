using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject Tsalida;
    private bool cerrado = true;
    // Start is called before the first frame update
    void Start()
    {

        Tsalida = GameObject.Find("Tsalida");
    }

    // Update is called once per frame
    void Update()
    {

        if (cerrado == true)
        {
            Tsalida.SetActive(false);

        }
        else if (cerrado == false)
        {
            Tsalida.SetActive(true);
            Time.timeScale = 0f;
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag.Equals("exit"))
        {
            cerrado = false;
            Destroy(other.gameObject);

        }
    }
    public void abrir()
    {
        if (cerrado == false)
        {

            
        }
    }
}