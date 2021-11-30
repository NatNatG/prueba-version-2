using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public int puntaje;
    public Text score;
    public GameObject final;
    private bool oculto = true;
    public void addScore(int marcador)
    {
        puntaje += marcador;
        score.text = "score: " + puntaje.ToString();
    }
    public bool gameover;

    public void detener()
    {
        gameover = true;

    }


    // Start is called before the first frame update
    void Start()
    {
        final = GameObject.Find("final1");
        AudioManager.instancia.PlayMusic(0, true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        score = GameObject.Find("score").GetComponent<Text>();
        
       
        if(gameover == true)
        {
            
            Time.timeScale = 0f;
            AudioManager.instancia.PlayMusic(0, false);
            LockCursor(false);
            oculto = false;
            
        }

        if (oculto == true)
        {
            final.SetActive(false);

        }
        else if (oculto == false)
        {
            final.SetActive(true);
            
        }
        
    }



    private void LockCursor(bool isLocked)
    {
        if (isLocked)
        {
            Cursor.visible = false;

            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;

            Cursor.lockState = CursorLockMode.None;
        }
    }
}
