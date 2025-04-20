using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    void Update()
    {
        float dx = Input.GetAxis("Mouse X");
        float dy = Input.GetAxis("Mouse Y");
        transform.Rotate(dy, -dx, 0f);
        CheckForRaycastHit();
    }
    void CheckForRaycastHit()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.collider.name+" destroyed!");
            Destroy(hit.collider.gameObject);
        }
    }
}