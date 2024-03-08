using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 20;
	private float lowerBound = -5;

    void Update()
    {
        //If an Object goes past the player view in the game, remove that object
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
