using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomperAsteroide : MonoBehaviour {

    public bool AsteroideGrande;

    public GameObject AsteroidePequeñoPrefab;
    AudioSource au;

    public GameObject Explosion;

    void Start()
    {
        au = Camera.main.GetComponent<AudioSource> ();
   
    }

    void Colision()
    {
        au.Play();
        Instantiate (Explosion, transform.position, Quaternion.identity);       // crea una explosion
        Puntajes.puntajeActual.ActualizarPuntaje ();

        if (AsteroideGrande)
        {  
            Instantiate(AsteroidePequeñoPrefab, transform.position + new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1)), Quaternion.identity);       // crea un asteroide chico al romperse el grande
            Instantiate(AsteroidePequeñoPrefab, transform.position + new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1)), Quaternion.identity);       // crea un asteroide chico al romperse el grande.
            Destroy(gameObject);            // destruye el asteroide grande
        } else
        {
            Destroy(gameObject);            //destruye el asteroide chico
        }

    }
}
