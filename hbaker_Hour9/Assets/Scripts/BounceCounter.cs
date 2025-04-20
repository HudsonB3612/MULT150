using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int count = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            count++;
            Debug.Log("Bounces: " + count);
        }
    }
}