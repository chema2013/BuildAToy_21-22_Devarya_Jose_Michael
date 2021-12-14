using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icefloor : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "IceFloor")
        {
            GetComponent<Collider>().material.dynamicFriction = 0;
        }
    }
}
