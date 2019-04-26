using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour {
    void Awake()
    {
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        Debug.Log(camera.transform.position);
    }
	
}
