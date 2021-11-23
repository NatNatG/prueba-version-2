using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public static GameManager GetInstancia()

    {
        return instancia;
    }

    private void Awake()
    {
        if (instancia == null)
            instancia = this;

        else if (instancia != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }
    public bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
