using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche : MonoBehaviour
{
    public float speed = 10f;
        private float rotationSpeed = 40f;
        private float horizontalInput;
        private float verticalInput;
        
        // Update is called once per frame
        void Update()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);
        }
}
