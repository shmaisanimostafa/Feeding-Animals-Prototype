using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		Destroy(gameObject);
		Destroy(collision.gameObject);
	}

}
