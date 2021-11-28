using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiadorCamara : MonoBehaviour
{
    public GameObject camara1;
    public GameObject camara2;
    public bool cam = true ;
    public  bool cam1 = false; 
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cam == true)
        {
            camara1.SetActive (false);
            camara2.SetActive  (true);
            
        }
        if (cam1 == true)
        {
            camara1.SetActive (true);
            camara2.SetActive (false);
            
        }

        if(Input.GetKeyDown("l"))
        {
            cam = false;
            cam1 = true;
        }
        if (Input.GetKeyDown("h"))
        {
            cam = true;
            cam1 = false;
        }
    }
}
