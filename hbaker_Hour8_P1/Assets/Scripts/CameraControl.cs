using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float moveSpeed = 0.1f;

    void Update()
    {
        float moveX = Input.GetAxis("Mouse X") * moveSpeed;
        float moveY = Input.GetAxis("Mouse Y") * moveSpeed;

        transform.Translate(new Vector3(moveX, moveY, 0f));
    }
}
