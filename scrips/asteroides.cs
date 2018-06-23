using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]            //requiere si o si un Rigidbody
public class asteroides : MonoBehaviour {

    public float Velocidad = 6;                 //velovidad del asteroide
    Rigidbody rb;
	void Start ()
    {
        rb = GetComponent<Rigidbody> ();
        rb.velocity = Vector3.back * Velocidad + Vector3.right * Random.Range(-1,1);                            //el asteroide se desplaza en un rango al azar entre -1 y 1
        rb.angularVelocity = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));        //el asteroide se mueve mientras gira
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Destroy (gameObject);
            col.SendMessage ("Daño", SendMessageOptions.DontRequireReceiver);           
        } 
    }
}
