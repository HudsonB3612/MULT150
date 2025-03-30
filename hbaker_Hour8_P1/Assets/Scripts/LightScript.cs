using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light pointLight;

    void Start()
    {
        pointLight = GetComponent<Light>();
        if (pointLight == null)
        {
            Debug.LogError("No Light component found");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            pointLight.enabled = !pointLight.enabled;
            Debug.Log("Light toggled: " + pointLight.enabled);
        }
    }
}