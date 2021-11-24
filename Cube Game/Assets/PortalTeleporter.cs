using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    public Transform Player;
    public Transform reciever;

    private bool playerIsOverlapping = false;


    // Update is called once per frame
    void Update()
    {
        if (playerIsOverlapping)
        {
            Vector3 portalToPlayer = Player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            if (dotProduct < 0f)
            {
                float rotationDiff = Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 180;
                Player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                Player.position = reciever.position + positionOffset;

                playerIsOverlapping = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }
}
