using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject pase;
    public bool bloqueado = true;
    // Start is called before the first frame update
    void Start()
    {
        
        pase = GameObject.Find("pase");
    }

    // Update is called once per frame
    void Update()
    {
        if(bloqueado==true)
        {
            pase.SetActive(false);

        }
        else if (bloqueado== false)
        {
            pase.SetActive(true);
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag.Equals("llave1"))
        {
            bloqueado = false; 
            Destroy(other.gameObject);

        }
    }
    public void desbloquear()
    {
        if(bloqueado == false)
        {
            
            pase.SetActive(true);
        }
    }
}
