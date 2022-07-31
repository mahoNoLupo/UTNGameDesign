using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionContinua : MonoBehaviour
{
    [SerializeField]
    private float velocidadX;
    [SerializeField]
    private float velocidadY;
    [SerializeField]
    private float velocidadZ;

   
    void Update()
    {
        RotatePlayer(velocidadX, velocidadY, velocidadZ);
    }

    void RotatePlayer(float x,float y, float z)
    {
        transform.Rotate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }
}
