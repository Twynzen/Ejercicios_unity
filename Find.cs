using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour {
 

    void Awake()
    {

        GameObject[] objects = GameObject.FindGameObjectsWithTag("Objects");
        foreach (GameObject go in objects)
            Debug.Log(go.transform.position);


        /*
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");//sirve para encontrar el valor que se le ponga

        Debug.Log(camera.transform.position);
        */
    }
	
}
