using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    private float MovimientoHorizontal;
    private float MovimientoVertical;
    private float MovimientoSalto;
    private float MovimientoCamaraX;
    private float MovimientoCamaraY;
    private float VelocidadMovimiento = 5.0f;
    private float VelocidadGiro = 50.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoHorizontal = Input.GetAxis("Horizontal");
        MovimientoVertical = Input.GetAxis("Vertical");
        MovimientoSalto = Input.GetAxis("Jump");
        MovimientoCamaraX = Input.GetAxis("Mouse X") * VelocidadGiro * Time.deltaTime;
        MovimientoCamaraY = Input.GetAxis("Mouse Y") * VelocidadGiro * Time.deltaTime;
        
        Vector3 movimiento = new Vector3(MovimientoHorizontal, MovimientoSalto, MovimientoVertical);
        transform.Translate(movimiento * VelocidadMovimiento * Time.deltaTime);

        //Vector3 rotacion = new Vector3(MovimientoCamaraX, 0f, MovimientoCamaraY);
        //transform.Rotate(rotacion * VelocidadGiro * Time.deltaTime);
        
        
    }
}
