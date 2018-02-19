using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody Body;
	private float x;
	private float y=0;
	private float z;
	public float speed;

	void Start(){
		Body = GetComponent<Rigidbody>();
	}


	void FixedUpdate (){
		x = Input.GetAxis("Horizontal");
		z = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(x*speed, y, z*speed);
		Body.AddForce(movement);

	}
}
