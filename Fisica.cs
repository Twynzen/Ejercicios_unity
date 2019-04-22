using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour {
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        float x = Random.Range(-1f, 1f);
        rb.AddForce(new Vector3(x,0f,1f) * 100f, ForceMode.Impulse);

        }
	









	/* Update is called once per frame
	void FixedUpdate () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce( Vector3.up * 50f, ForceMode.Force);//fuerza continua que depende de la maza
    } 
    */
}
/*rb = GetComponent<Rigidbody>();
rb.AddForce(Vector3.right* 50f, ForceMode.Impulse); //El impulse es un solo impulso inicial
 ForceMode.Force: depende de la maza la fuerza de su empuje
 ForceMode.Acceleration: le da igual la masa del objeto
 Vector3.one: hace que sus componentes valgan 1
 Vector3.up:una fuerza para arriba*/
