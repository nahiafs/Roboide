using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba6 : MonoBehaviour
{
    private static int numMonedas;
    private GameObject muro;
    
    // Start is called before the first frame update
    void Start()
    {
        numMonedas = 0;
        muro = GameObject.Find("Muro");
    }

    private void Update()
    {
        if (numMonedas == 3)
        {
            Destroy(muro);
        }
    }

    public static void sumaMoneda()
    {
        numMonedas++;
        Debug.Log(numMonedas);
    }
}
