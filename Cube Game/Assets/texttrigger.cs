using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texttrigger : MonoBehaviour
{
    public GameObject uiObject;
    private void Start()
    {
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider Player)
    {
        if(Player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    private IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}
