using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaNave : MonoBehaviour {

    public int CantidadDeVidas = 3;            // cantidad de vidas de jugador

    public Image Img;

    public Sprite TresVidas;
    public Sprite DosVidas;
    public Sprite UnaVida;

    void Start()
    {
        CantidadDeVidas = 3;
        Img.sprite = TresVidas;
    }
    public void Daño()
    {
        CantidadDeVidas--;              // cada vez que la nave colisiona pierde una vida

        if (CantidadDeVidas == 3)
        {
            Img.sprite = TresVidas;     //muestra el sprite de 3 vidas
        }
        else if(CantidadDeVidas == 2)
        {
            Img.sprite = DosVidas;      //muestra el sprite de 2 vidas
        }
        else if (CantidadDeVidas == 1)
        {
            Img.sprite = UnaVida;       //muestra el sprite de 1 vidas
        }
        else
        {
            if (Perder.EnJuego)
            SendMessage("perder", SendMessageOptions.DontRequireReceiver);
        }
    }
}
