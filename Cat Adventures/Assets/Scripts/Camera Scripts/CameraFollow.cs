using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float camSpeed = 0.125f;

    public Vector3 offset;

    //Same as update, but run right after update. This helps to avoid a weird camera movement since the cam moves after the player.
    void LateUpdate()
    {   
        Vector3 desiredPosition = target.position + offset;
        transform.position = desiredPosition;

        transform.LookAt(target);
    }
}
