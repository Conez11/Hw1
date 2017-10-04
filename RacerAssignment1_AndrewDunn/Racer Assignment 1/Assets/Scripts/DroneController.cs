using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour {

	public GameObject player;
	public GameObject playerExplosion;
	public bool horizontal;
	public bool direction;
	public float speed;
	public float rotate;

//	Vector3 Vec = new Vector3 (0.0f, 10, 0.0f);

	private Rigidbody rb;

	void Start () {

		rb = GetComponent<Rigidbody>();

		if (direction && horizontal)
		{
			rb.velocity = transform.right * speed;
		}

		if (!direction && horizontal) {
			rb.velocity = transform.right * ( speed * -1 );
		}

		if (direction && !horizontal)
		{
			rb.velocity = transform.forward * speed;
		}

		if (!direction && !horizontal) {
			rb.velocity = transform.right * ( speed * -1 );
		} else {
			return;
		}
			
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (player);
		} else {
			direction = !direction;
		}
	}

	void Update () 
	{
//		transform.Rotate (rotate*Vec * Time.deltaTime);

		if (direction && horizontal)
		{
			rb.velocity = transform.right * speed;
		}

		if (!direction && horizontal) {
			rb.velocity = transform.right * ( speed * -1 );
		}

		if (direction && !horizontal)
		{
			rb.velocity = transform.forward * speed;
		}

		if (!direction && !horizontal) {
			rb.velocity = transform.right * ( speed * -1 );
		} else {
			return;
		}
	}
/*	void fixedUpdate()
	{
		if (rb.position.x <= 1.0f) {
			Vector3 spin = (Vec - transform.position).normalized;

			rb.MovePosition (transform.position + spin * rotate * Time.fixedDeltaTime);
		}
	} */
}
