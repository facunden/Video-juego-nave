using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntajes : MonoBehaviour {

    public Text tt;
    public int puntaje;

    public static Puntajes puntajeActual;

    void Start()
    {
        puntajeActual = this;
    }

    public void ActualizarPuntaje()
    {
        puntaje++;
        tt.text = puntaje.ToString();

    }
}
