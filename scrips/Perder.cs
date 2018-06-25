using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perder : MonoBehaviour {

    public GameObject MenuPerder;
    public static bool EnJuego;

    void Start()
    {
        EnJuego = true; 

        MenuPerder.SetActive(false);
    }
	public void Reiniciar()
    {

        SceneManager.LoadScene(0);  //Al perder todas las vidas, se vuelve a la Escena 0 (inicio)
    }
    public void perder()
    {
        EnJuego = false;
        MenuPerder.SetActive (true);

    }
}
