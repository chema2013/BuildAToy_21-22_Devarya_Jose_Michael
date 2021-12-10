using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform MainCamera;
    public Transform portal;
    public Transform otherPortal;
    void Update()
    {
        Vector3 playerOffsetFromPortal = MainCamera.position - otherPortal.position;
        transform.position = portal.position + playerOffsetFromPortal;

        float angularDifferencebetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

        Quaternion portalRotationDifference = Quaternion.AngleAxis(angularDifferencebetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationDifference * MainCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }
}
