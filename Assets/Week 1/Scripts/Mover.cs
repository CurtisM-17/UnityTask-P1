using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 10f;
    public GameObject missilePrefab;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Horizontal");
        transform.Translate(keyboardInput * speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(missilePrefab, spawn.position, spawn.rotation);
        }
    }
}
