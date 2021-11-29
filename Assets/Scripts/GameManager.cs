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

    public void addScore(int marcador)
    {
        puntaje += marcador;
        score.text = "score: " + puntaje.ToString();
    }
    public bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instancia.PlayMusic(0, true);
    }

    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("score").GetComponent<Text>();
    }
}
