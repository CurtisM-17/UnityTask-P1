using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 15f;
	Rigidbody2D rigidBody;

	// Start is called before the first frame update
	void Start()
    {
		rigidBody = gameObject.GetComponent<Rigidbody2D>();

		Destroy(gameObject, 5);
	}

	// Update is called once per frame
	private void Update()
	{
		//transform.Translate(speed * Time.deltaTime, 0, 0);
	}

	private void FixedUpdate()
	{
		Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
		rigidBody.MovePosition(rigidBody.position + direction);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
		Destroy(gameObject);
		Debug.Log(collision.gameObject);
    }
}
