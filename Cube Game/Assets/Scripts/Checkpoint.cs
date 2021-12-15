using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform checkpoint;
    GameObject player;

    public Rigidbody momentum;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player") 
        {
            player.transform.position = checkpoint.position;
            player.transform.rotation = checkpoint.rotation;
            

            momentum.velocity = Vector3.zero;
            momentum.angularVelocity = Vector3.zero;
        }
    }
    
}
