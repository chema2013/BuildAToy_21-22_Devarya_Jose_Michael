using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating_wall : MonoBehaviour
{

// speed of the turning wall

    public float speed = 80f; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
