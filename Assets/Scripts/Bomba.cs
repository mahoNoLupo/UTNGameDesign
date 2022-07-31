using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Explotar"))
        {
            Destroy(this);
        }
    }
}
