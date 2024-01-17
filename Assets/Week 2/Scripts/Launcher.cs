using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject missile;
    Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnpoint = transform.Find("Spawn Point").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(missile, spawnpoint.position, spawnpoint.rotation);
    }
}
