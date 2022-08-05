using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    [SerializeField]
    private bool isExplode;
    [SerializeField]
    private float explodeTime;

    private void Awake()
    {
        Invoke("Explode", explodeTime);
        Debug.Log("BOMB AWAKE");
    }
    void Update()
    {
        if (Input.GetButton("Explotar"))
        {
            isExplode = true;
        }
    }

    void Explode()
    {
        isExplode = true;
    }

    private void OnTriggerStay(Collider c)
    {
        Debug.Log("Colision trigger with: " + c.gameObject.name);
        Destroy(c);
        if (isExplode == true)
        {
            Destroy(this);
        }
    }
}
