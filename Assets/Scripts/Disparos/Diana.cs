using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bala")
        {
            Destroy(this.gameObject);
            RondaDisparos.aniadirDiana("Diana");
        }
    }
}
