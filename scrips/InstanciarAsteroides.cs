using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarAsteroides : MonoBehaviour {

    public float InstanceRate = 2;          // cantidad de segundos que genera asteroides
    public GameObject AsteroidePrefab;
	IEnumerator Start () {                  //IEnumerator es un tipo de funsion que permite utilizar la linea 13
        while (true)
        {
            Instantiate(AsteroidePrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(InstanceRate);          //cada tantos segundos genera asteroides
        }
	}
	
}
