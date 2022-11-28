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
    private float VelocidadCorrer = 10.0f;
    private float VelocidadGiro = 50.0f;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoHorizontal = Input.GetAxis("Horizontal");
        MovimientoVertical = Input.GetAxis("Vertical");
        MovimientoSalto = Input.GetAxis("Jump");
        MovimientoCamaraX = Input.GetAxis("Mouse X") * VelocidadGiro * Time.deltaTime;
        MovimientoCamaraY = Input.GetAxis("Mouse Y") * VelocidadGiro * Time.deltaTime;
        
        Vector3 movimiento = new Vector3(MovimientoHorizontal, 0f, MovimientoVertical);
        
        if (MovimientoHorizontal <= 0 && MovimientoVertical <= 0)
        {
            animator.SetFloat("Blend", 0f);
        } 
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(movimiento * VelocidadCorrer * Time.deltaTime);
            animator.SetFloat("Blend", 1f);
        }
        else
        {
            transform.Translate(movimiento * VelocidadMovimiento * Time.deltaTime);
            animator.SetFloat("Blend", 0.5f);
        }
        
        transform.Rotate(new Vector3(0, 1, 0), MovimientoHorizontal * VelocidadGiro * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(transform.up * MovimientoSalto * Time.deltaTime);
        }
    }
}
