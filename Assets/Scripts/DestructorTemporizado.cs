using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorTemporizado : MonoBehaviour
{
    [SerializeField]
    private float timeToExec;
    // Start is called before the first frame update
    private void Awake()
    {
        Invoke("Autodestroy", timeToExec);
    }
    private void Autodestroy()
    {
        Destroy(this);
    }
}
