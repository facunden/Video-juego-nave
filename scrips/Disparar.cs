using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public AudioSource au;
    public Transform LanzadorL;
    public Transform LanzadorR;

    public GameObject DisparoPrefab;
	
	void Update () {
        if (Perder.EnJuego)
        {
            if (Input.GetButtonDown("Jump"))                    //si se presiona la tecla Jump (espacio)
            {
                au.Play();              //activa el sonido al disparar
                Instantiate(DisparoPrefab, LanzadorL.position, DisparoPrefab.transform.rotation);       //disparos de la nave izquierda
                Instantiate(DisparoPrefab, LanzadorR.position, DisparoPrefab.transform.rotation);       //disparos de la nave derecha
            }
        }
        else {
            
        }
	}
}
