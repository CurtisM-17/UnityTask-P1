using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        door.SetActive(!door.activeInHierarchy);
    }
}
