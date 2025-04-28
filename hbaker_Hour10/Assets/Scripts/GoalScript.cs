using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private bool solved = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            solved = true;
            other.GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Light>().intensity = 0.5f;
        }
    }
    public bool IsSolved()
    {
        return solved;
    }
}
