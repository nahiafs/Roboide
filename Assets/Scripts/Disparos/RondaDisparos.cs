using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RondaDisparos : MonoBehaviour
{
    public int dianasTotales;
    static List<string> dianas;
    
    // Start is called before the first frame update
    void Start()
    {
        dianas = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dianas.Count == dianasTotales)
        {
            Destroy(this.gameObject);
        }
    }

    public static void aniadirDiana(string diana)
    {
        dianas.Add(diana);
    }
}
