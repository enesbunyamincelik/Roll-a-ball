using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeKontrol : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 vektor = new Vector3(15, 30, 45);

        transform.Rotate(vektor*0.01f);
    }
}
