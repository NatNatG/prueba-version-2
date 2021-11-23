using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    public GameObject objetoBase;
    public int numeroObjetos;

    private GameObject[] PoolObjetos;

    // Start is called before the first frame update
    void Start()
    {
        PoolObjetos = new GameObject[numeroObjetos];

        for (int i = 0; i < numeroObjetos; i++)
        {
            GameObject copia = Instantiate(objetoBase);
            PoolObjetos[i] = copia;
            PoolObjetos[i].SetActive(false);
        }
    }

    public GameObject GetObjetoDelPool()
    {
        for (int i = 0; i < numeroObjetos; i++)
        {
            if (! PoolObjetos[i].activeInHierarchy)
            {
                PoolObjetos[i].SetActive(true);
                return PoolObjetos[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}