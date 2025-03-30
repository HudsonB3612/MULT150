using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public float scaleStep = 0.1f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 rotation = new Vector3(-mouseY, mouseX, 0) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation);

        if (Input.GetKey(KeyCode.M))
        {
            transform.localScale += new Vector3(scaleStep, scaleStep, scaleStep);
        }
        if (Input.GetKey(KeyCode.N))
        {
            transform.localScale -= new Vector3(scaleStep, scaleStep, scaleStep);
            if (transform.localScale.x < 0.1f)
            {
                transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            }
        }
    }
}