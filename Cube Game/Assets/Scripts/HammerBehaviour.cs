using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerBehaviour : MonoBehaviour
{


    float speed = 80f; 

    public float rotationLevelLeast;

    public float rotationLevelMost;

    public GameObject[] map;

    public bool left;

    public bool right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.rotation.z > 90 && left == true)
        {
         transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 50), speed * Time.deltaTime);
        }
        if (gameObject.transform.rotation.z < 270 && left == false)
        {
           transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, -50), speed * Time.deltaTime); 
        }
        
    }
}
