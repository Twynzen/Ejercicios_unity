using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject prefab;
    


	// Use this for initialization
	void Start () {
        Instantiate(prefab, transform.position, transform.rotation);//pedimos que se instanci el prefab en esta posicion con eta rotacion
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
	}
}
