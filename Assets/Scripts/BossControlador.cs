using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Animator))]
public class BossControlador : MonoBehaviour
{
    public int life;
    //public GameObject LaserPrefab;
    public Transform LaserMuzzle;

    private Slider HPSlider;

    private Animator BossAnimator;
    public GameObject BossHPSlider;
    // Start is called before the first frame update
    private void Start()
    {

        BossAnimator = GetComponent<Animator>();
        HPSlider = BossHPSlider.GetComponent<Slider>();

        HPSlider.value = 1;

    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerLaser"))
        {
            DamageBoss(2);
        }
    }

    //animacion de daño y slider 
    public void DamageBoss(int damage)
    {
        life -= (damage);
        BossAnimator.SetTrigger("hit");


        //aqui baja la vida
        HPSlider.value = life / 100.0f;
    }
}

