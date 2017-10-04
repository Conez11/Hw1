using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereSpikesController : MonoBehaviour {
	
	public GameObject player;
	public float tilt;
	public float speed;
	//public float zRotation;

	private Vector3 offset;

	void Start ()
	{

		offset = transform.position - player.transform.position;
	}

	void Update ()
	{
		transform.position = player.transform.position + offset;
	}
		
}
