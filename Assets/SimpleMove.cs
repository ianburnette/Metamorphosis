using UnityEngine;
using System.Collections;

public class SimpleMove : MonoBehaviour {

	public float speed;
	Rigidbody rb;
	float h, v;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

		rb.AddForce (new Vector3 (h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime));
	}
}
