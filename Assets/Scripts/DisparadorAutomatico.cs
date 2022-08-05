using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private float timeToInvoke;
    [SerializeField]
    private float repeatTime;

    private void Awake()
    {
        InvokeRepeating("Disparar", timeToInvoke, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Disparar()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

}
