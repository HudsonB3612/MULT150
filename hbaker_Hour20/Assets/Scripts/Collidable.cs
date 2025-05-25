using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;

    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.AdjustTime(timeAmount);
            Destroy(gameObject);
        }
    }
}