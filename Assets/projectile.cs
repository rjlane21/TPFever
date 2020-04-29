using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotation = 100.0f;

    void Update()
    {
        // Make it move 10 meters per second instead of 10 meters per frame...
        rotation *= Time.deltaTime;

        // Rotate around our y-axis
        transform.Rotate(0, 0, rotation);
    }
}
