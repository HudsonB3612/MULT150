using UnityEngine;

public class MouseInput : MonoBehaviour
{
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        if (mxVal != 0)
            print("Mouse X movement: " + mxVal);
        if (myVal != 0)
            print("Mouse Y movement: " + myVal);
    }
}