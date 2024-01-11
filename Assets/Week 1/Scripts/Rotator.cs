using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 360f;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        
=======
>>>>>>> Week1-Task3
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -speed * Time.deltaTime);
    }
}
