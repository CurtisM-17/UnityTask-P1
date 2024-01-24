using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float steeringSpeed = 2;
    public float forwardSpeed = 2;
    public float maxSpeed = 3;
    public Rigidbody2D rigidBody;
    public GameObject explosion;

    float steering, acceleration;

    float throttleTime = 0; // How long the car has been driving for since last stop

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

		if (acceleration == 0) throttleTime = 0;
		else throttleTime += Time.deltaTime;
	}

	/// Die in an explosion if crashing at too high-speed into the red barrel
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (throttleTime < 2.5)
        {
            Debug.Log("Not enough momentum for explosion");
            return;
        }
        if (collision.gameObject.name != "Exploding Barrel") return;

        /// Create an explosion in the middle position between the barrel and the car
        Vector2 middlePos = (gameObject.transform.position + collision.gameObject.transform.position) / 2;

        GameObject boom = Instantiate(explosion, middlePos, new Quaternion(0, 0, 0, 0));
        Destroy(collision.gameObject);
		Destroy(boom, 1);
		Destroy(gameObject);
	}
}
