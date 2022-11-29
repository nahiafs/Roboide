using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuertas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (GameObject.FindWithTag("Fin"))
        {
            Debug.Log("TOCA");
            GameObject puerta = GameObject.FindWithTag("Puerta");
            Destroy(puerta);
        }
    }
}
