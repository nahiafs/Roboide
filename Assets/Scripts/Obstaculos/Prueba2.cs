using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Prueba2 : MonoBehaviour
{
    private GameObject obstaculo;
    private GameObject obstaculo2;
    private GameObject obstaculo3;
    
    private float[] zonasAlto = {-2, 1, 4, 7, 10, 12};
    private float[] zonasBajo = {-0.5f, 2.5f, 5.5f, 8.5f, 10.5f};

    // Start is called before the first frame update
    void Start()
    {
        obstaculo = Resources.Load("Obstaculo", typeof(GameObject)) as GameObject;
        obstaculo2 = Resources.Load("Obstaculo2", typeof(GameObject)) as GameObject;
        obstaculo3 = Resources.Load("Obstaculo3", typeof(GameObject)) as GameObject;
        
        for (int i = 1; i <= 3; i++)
        {
            Invoke("generarObstaculos", i * 5f);
        }
        
        Invoke("quitarMuro", 16f);
    }
    
    public void generarObstaculos()
    {
        for (int i = 0; i < Random.Range(4, 6); i++)
        {
            Instantiate(obstaculo, new Vector3(zonasAlto[Random.Range(0, zonasAlto.Length)], obstaculo.transform.position.y, obstaculo.transform.position.z), Quaternion.identity);
            Instantiate(obstaculo2, new Vector3(zonasBajo[Random.Range(0, zonasBajo.Length)], obstaculo2.transform.position.y, obstaculo2.transform.position.z), Quaternion.identity);
            Instantiate(obstaculo3, new Vector3(zonasBajo[Random.Range(0, zonasBajo.Length)], obstaculo.transform.position.y, obstaculo.transform.position.z), Quaternion.identity);
        }
    }

    public void quitarMuro()
    {
        Destroy(GameObject.Find("Muro"));
    }
}
