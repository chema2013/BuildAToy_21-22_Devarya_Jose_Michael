using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindWithTag("Player").SendMessage("Finish");
    }
}
