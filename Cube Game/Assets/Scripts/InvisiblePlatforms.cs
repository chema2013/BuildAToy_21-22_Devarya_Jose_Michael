using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisiblePlatforms : MonoBehaviour
{

     

     public GameObject Ip;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      if(Input.GetKey("e"))
      {

          Ip.SetActive(true);

          Debug.Log("pressing space");
          
        }
        else
        {

          Ip.SetActive(false);
        }
    }
}
