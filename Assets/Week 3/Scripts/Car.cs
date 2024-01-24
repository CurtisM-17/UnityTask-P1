using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float steeringSpeed = 2;
    public float forwardSpeed = 2;
    public float maxSpeed = 3;
    public Rigidbody2D rigidBody;

    float steering, acceleration;

    // Update is called once per frame
    void Update()
    {
        steering = Input.GetAxis("Horizontal");
        acceleration = Input.GetAxis("Vertical");
    }

	private void FixedUpdate()
	{
        rigidBody.AddTorque(steeringSpeed * -steering * Time.deltaTime);

        Vector2 force = Time.deltaTime * forwardSpeed * acceleration * transform.up;
		rigidBody.AddForce(force);

        if(rigidBody.velocity.magnitude < maxSpeed)
        {
            rigidBody.AddForce(force);
        }
	}
}
