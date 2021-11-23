using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restriccion : MonoBehaviour
{
    public float sensibilidadX = 2f;
    public float sensibilidadY = 2f;

    public float rotMinX = -90f;
    public float rotMaxX = 90f;

    private Quaternion rotacionPersonaje;
    private Quaternion rotacionCamara;

    private Transform transformPersonaje;
    private Transform transformCamara;

    // Start is called before the first frame update
    void Start()
    {
        transformCamara = Camera.main.transform;
        transformPersonaje = transform;

        rotacionPersonaje = transformPersonaje.rotation;
        rotacionCamara = transformCamara.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetInstancia().gameover == false)
        {
            RotacionVista();

            if (Input.GetButtonDown("Fire1"))
                LockCursor(true);

            if (Input.GetButtonDown("Cancel"))
                LockCursor(false);
        }
    }

    private void RotacionVista()
    {
        float rotX = Input.GetAxis("Mouse Y") * sensibilidadY;
        float rotY = Input.GetAxis("Mouse X") * sensibilidadX;

        rotacionPersonaje = rotacionPersonaje * Quaternion.Euler(0f, rotY, 0f);

        rotacionCamara = rotacionCamara * Quaternion.Euler(-rotX, 0f, 0f);

        rotacionCamara = RestringirRotacionX(rotacionCamara);

        transformPersonaje.localRotation = rotacionPersonaje;

        transformCamara.localRotation = rotacionCamara;
    }

    private Quaternion RestringirRotacionX(Quaternion quaternionActual)
    {
        quaternionActual.x /= quaternionActual.w;
        quaternionActual.y /= quaternionActual.w;
        quaternionActual.z /= quaternionActual.w;
        quaternionActual.w = 1f;

        float anguloX = 2f * Mathf.Rad2Deg * Mathf.Atan(quaternionActual.x);

        anguloX = Mathf.Clamp(anguloX, rotMinX, rotMaxX);

        quaternionActual.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * anguloX);

        return quaternionActual;
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
