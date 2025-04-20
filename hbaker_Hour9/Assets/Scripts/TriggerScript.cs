using UnityEngine;
public class TriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name+" entered");
    }
    
    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name+" inside");
    }
    
    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name+" exited");
    }
}