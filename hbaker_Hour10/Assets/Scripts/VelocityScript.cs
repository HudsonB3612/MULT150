using UnityEngine;

public class VelocityScript : MonoBehaviour {
    public float max = 50;
    void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(0, max), 0, Random.Range(0, max));
    }
}