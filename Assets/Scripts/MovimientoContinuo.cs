using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoContinuo : MonoBehaviour
{
    [SerializeField]
    float velocidadX;
    [SerializeField]
    float velocidadY;
    [SerializeField]
    float velocidadZ;


    void Update()
    {
        MovePlayer(velocidadX, velocidadY, velocidadZ);
    }

    void MovePlayer(float x, float y, float z)
    {
        transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }
}
