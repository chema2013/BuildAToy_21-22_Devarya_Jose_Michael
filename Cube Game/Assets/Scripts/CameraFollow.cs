
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;

    private void LateUpdate()
    {
        transform.position = target.position;
    }
}
