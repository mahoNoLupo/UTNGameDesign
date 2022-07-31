using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [SerializeField]
    private float velocidadMovimiento;
    [SerializeField]
    private float velocidadRotacion;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer(velocidadMovimiento);
        rotatePlayer(velocidadRotacion);
    }

    void movePlayer(float vel)
    {
        if (Input.GetButton("Arriba"))
        {
            transform.Translate(Vector3.forward * -vel * Time.deltaTime);
        }
        if (Input.GetButton("Abajo"))
        {
            transform.Translate(Vector3.forward * vel * Time.deltaTime);
        }
    }

    void rotatePlayer(float vel)
    {
        if (Input.GetButton("Izquierda"))
        {
            transform.Rotate(Vector3.down * vel * Time.deltaTime);
        }
        if (Input.GetButton("Derecha"))
        {
            transform.Rotate(Vector3.up * vel * Time.deltaTime);
        }
    }
}
