using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float deltaRotation = 30f;
    public float deltaMovement = 10f;

    public Color color;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Renderer>().material.color = color;

    }
	
	// Update is called once per frame
	void Update ()
    {
        Rotate();
        Moverse();
        
	}
    void Rotate()
    {//El detal time ayuda a que sea consistente el frame en todos los computadores
        if(Input.GetKey(KeyCode.Q))
        transform.Rotate(new Vector3(0f, -deltaRotation, 0f) * Time.deltaTime);
        else if(Input.GetKey(KeyCode.E))
        transform.Rotate(new Vector3(0f, deltaRotation, 0f) * Time.deltaTime);
    }
    void Moverse()
    {
        if (Input.GetKey(KeyCode.W))
        transform.Translate(Vector3.forward* deltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);

    }

}
