using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour 
{
	public GameObject playerExplosion;
	public GameObject player;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (player);
		} 
		else {
			return;
		}
	}
}
