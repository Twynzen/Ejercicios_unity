using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject prefab;

    private int count = 0;
    


	// Use this for initialization
	void Start () {
        Instantiate(prefab, transform.position, transform.rotation);//pedimos que se instanci el prefab en esta posicion con eta rotacion
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        {
           GameObject cube = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
            cube.name = "cubito" + count++;
            Destroy(cube, 3f);

        }
	}
}
