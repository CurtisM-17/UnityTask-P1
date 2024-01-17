using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float speed = 5f;
    Vector2 direction;

    private void Start()
    {
		rigidBody = gameObject.GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
	}

    private void FixedUpdate()
    {
		Vector2 force =  speed * Time.deltaTime * direction;
		rigidBody.AddForce(force);
	}
}
