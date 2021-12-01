using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class control : MonoBehaviour
{
    public float velocidad = 3.0f;
    public float gravedad = 9.81f;
    public int hitpoints;
    private Text vida;
    public float limiteSalto;
    public float cantidadSalto;
    public float deltaSalto;

    private Vector3 movimiento;

    private CharacterController mCharacterController;

    // Start is called before the first frame update
    void Start()
    {
        mCharacterController = GetComponent<CharacterController>();
        vida = GameObject.Find("Vida").GetComponent<Text>();
        vida.text = "Vida:" + hitpoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 velX;
        Vector3 velZ;

        velZ = Vector3.forward * velocidad * Time.deltaTime * z;
        velX = Vector3.right * velocidad * Time.deltaTime * x;

        movimiento = transform.TransformDirection(velX + velZ);

        if (Input.GetAxis("Jump") != 0f && mCharacterController.isGrounded)
        {
            cantidadSalto = 0f;
        }
        if (!Saltar())
        {
            movimiento.y -= gravedad * Time.deltaTime;
        }

        mCharacterController.Move(movimiento);
    }

    private bool Saltar()
    {
        if (cantidadSalto < limiteSalto)
        {
            movimiento.y += deltaSalto;
            cantidadSalto += deltaSalto;
            return true;
        }
        else
            return false;
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag.Equals("EnemyLaser"))
        {
            hitpoints--;

            vida.text = "Vida:" + hitpoints.ToString();

            Destroy(other.gameObject);


           

        }

        if (other.CompareTag("enemy"))
        {

            hitpoints -= 3;

            vida.text = "Vida:" + hitpoints.ToString();

           
        }
        if (other.CompareTag("Bonus"))
        {
            hitpoints += 1;
            vida.text = "Vida:" + hitpoints.ToString();
        }
    }
}