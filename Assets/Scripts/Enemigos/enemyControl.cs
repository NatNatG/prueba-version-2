using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControl : MonoBehaviour
{
    public int life;
    //public GameObject LaserPrefab;
    public Transform enemyMuzzle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destruir();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerLaser"))
        {
            DamageBoss(2);
        }


    }
    public void DamageBoss(int damage)
    {
        life -= (damage);
        //BossAnimator.SetTrigger("hit");


        //aqui baja la vida
        //HPSlider.value = life / 50.0f;
    }

    public void Destruir()
    {
        if (life <= 0)
        {
            Destroy(gameObject);

        }
    }
}
