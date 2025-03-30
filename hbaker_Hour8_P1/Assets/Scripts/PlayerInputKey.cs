using UnityEngine;

public class PlayerInputKey : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
            print("The 'M' key is pressed down");
    }
}