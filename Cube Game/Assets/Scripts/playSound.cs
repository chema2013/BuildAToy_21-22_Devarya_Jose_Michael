using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{

    AudioSource audioData;

    public AudioSource[] sounds;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            audioData = sounds[0]; 
            audioData.Play(0);
        }

        if (collision.gameObject.tag == "power")
        {
            audioData = sounds[2]; 
            audioData.Play(0);
        }

        if (collision.gameObject.tag == "Death")
        {
            audioData = sounds[1]; 
            audioData.Play(0);
        }

        if (collision.gameObject.tag == "boost")
        {
            audioData = sounds[3]; 
            audioData.Play(0);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Death")
        {
            audioData = sounds[1]; 
            audioData.Play(0);
        }
    }
}
