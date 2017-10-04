using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speedForward;
	public float speedSide;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveHorizontal * speedSide, 0.0f, speedForward);

		rb.velocity = movement;
	}
}
