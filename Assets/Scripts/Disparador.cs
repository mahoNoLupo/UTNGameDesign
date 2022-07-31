using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private string nombreAccion;
    void Start()
    {

    }


    void Update()
    {
        shoot(prefab, nombreAccion);
    }

    private void shoot(GameObject pf, string action)
    {
        if (Input.GetButton(action))
        {
            Instantiate(pf, transform.position, transform.rotation);
        }
    }
}
