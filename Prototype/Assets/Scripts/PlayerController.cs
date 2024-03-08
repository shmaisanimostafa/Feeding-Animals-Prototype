using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *  horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, 0, 0);
        }
		if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, 0, 0);
		}

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

	}
}
