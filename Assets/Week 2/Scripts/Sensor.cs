using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
	SpriteRenderer spriteRenderer;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();

		spriteRenderer.color = Color.green;
	}

	// Trigger enter
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!spriteRenderer) return;

		Debug.Log(collision.gameObject.name + " is in the trigger");
		spriteRenderer.color = Color.red;
	}

	// Trigger exit
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (!spriteRenderer) return;

		Debug.Log(collision.gameObject.name + " left the trigger");
		spriteRenderer.color = Color.green;
	}
}
