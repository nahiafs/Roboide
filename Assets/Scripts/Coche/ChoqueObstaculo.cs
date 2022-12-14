using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoqueObstaculo : MonoBehaviour
{
    public GameObject personaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje")
        {
            personaje.transform.position = new Vector3(5, 0.65f, -85);
        }
    }
}
