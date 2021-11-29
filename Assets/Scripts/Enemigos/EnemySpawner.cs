using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> Enemies;
    //public List<GameObject> EnemiesWSaypoints;

    // Start is called before the first frame update
    void Awake()
    {

        foreach (GameObject enemy in Enemies)
        {
            enemy.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    { //activamos los spawners
        if (other.tag.Equals("Player"))
        {

            foreach (GameObject enemy in Enemies)
            {
                enemy.SetActive(true);
            }
        }
    }
}
