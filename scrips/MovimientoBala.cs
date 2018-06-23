using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour {

    public float Velocidad = 20;                    //velocidad de los disparos

    void Start(){
        Destroy(gameObject, 5);                     //se eliminan los disparos tras 5 segundos para que no ocupen memoria

    }
    void OnTriggerEnter(Collider col)               
    {
        if(col.CompareTag("Asteroides"))           //si las balas impactas con un asteroide 
        {
            Destroy(gameObject);                  // el asteroide se destruye
            col.SendMessage("Colision", SendMessageOptions.DontRequireReceiver);        
        }

    }

	void Update () {

        transform.position += transform.up * Velocidad * Time.deltaTime;                //Time.deltaTime vendria a ser un control del tiempo
	}
}
