using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private string nombreAccion;
    [SerializeField]
    private float timeToInvoke;
    [SerializeField]
    private float repeatTime;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown(nombreAccion))
        {
            InvokeRepeating("Shoot", timeToInvoke, repeatTime);
        }
        if (Input.GetButtonUp(nombreAccion))
        {
            CancelInvoke();
        }
    }

    private void Shoot()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
