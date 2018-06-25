using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]               //requiere si o si un rigidbody
public class scriptsDeMovimiento : MonoBehaviour
{

    Rigidbody rb;
    public float Velocidad = 8;                     //velocidad de la nave
	void Start ()
    {
        rb = GetComponent<Rigidbody> ();            
	}
	
	void Update ()
    {
        Vector3 VectorVelocidad;
        if (Perder.EnJuego) {
            Vector3 DireccionX = Input.GetAxis("Horizontal") * Vector3.right;          //movimiento horizontal de la nave
            Vector3 DireccionZ = Input.GetAxis("Vertical") * Vector3.forward;          //movimiento vertical de la nave

            Vector3 Direccion = DireccionX + DireccionZ;
            VectorVelocidad = Direccion * Velocidad;
            
        }
        else
        {
            VectorVelocidad = Vector3.zero;
        }
        rb.velocity = VectorVelocidad;
    }
}
