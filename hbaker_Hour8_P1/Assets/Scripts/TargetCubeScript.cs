using UnityEngine;

public class TargetCubeScript : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        target = GameObject.Find("Cube");
    }

    void Update()
    {
        if (target != null)
        {
            target.transform.Translate(0.05f, 0f, 0f);
            target.transform.Rotate(0f, 0f, 1f);
            target.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
    }
}