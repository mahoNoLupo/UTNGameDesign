using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOleadas : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private float timeToExec;
    [SerializeField]
    private float startToExec;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("Generate", startToExec, timeToExec);
    }

    private void Generate()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
