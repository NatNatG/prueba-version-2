using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader instancia;
    public static LevelLoader GetInstanciaLevel()
    {
        return instancia;

    }

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);



        }
    }

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public bool gameover = false;

    /*private void Update()
    {
        ChecarGameOver();
        LoadLevel(1);
    }
    public void ChecarGameOver()
    {
        if(gameover == false)
        {
            

            
        }
    }*/

     public void LoadLevel(int sceneIndex)
     {

       StartCoroutine(LoadAsynchronously(sceneIndex));

     }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        Time.timeScale = 1f;


        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);


        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            progressText.text = progress * 100f + "%";


            yield return null;


            //GameObject.Find("***GameManager***").GetComponent<GameManager>().DesactivarGameOver();


        }

        //GameObject.Find("***GameManager***").GetComponent<GameManager>().DesactivarGameOver();

    }
}
