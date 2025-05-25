using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        // I used time.deltaTime because I believe it will sync it up with the current FPS of the game
    }
}