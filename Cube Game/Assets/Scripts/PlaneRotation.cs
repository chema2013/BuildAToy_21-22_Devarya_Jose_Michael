using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotation : MonoBehaviour
{
    public GameObject[] map;

    public float rotationLevel;

    public float rotationLevelLeast;

    public float rotationLevelMost;

    public float rotationWait;

    public float rotationMostWait;


    public float rotationLeastWait;

    public int startWait;

    public bool stop;
    float speed = 50F; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitRotation());
    }

    // Update is called once per frame
    void Update()
    {
        rotationWait = Random.Range (rotationLeastWait, rotationMostWait);

        rotationLevel = Random.Range (rotationLevelLeast, rotationLevelMost);

        
    }

    IEnumerator waitRotation()
    {
        yield return new WaitForSeconds (startWait);

        while (!stop)
        {

            
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(rotationLevel, rotationLevel, rotationLevel), speed * Time.deltaTime);

            yield return new WaitForSeconds (rotationWait);

        }
    }
}
