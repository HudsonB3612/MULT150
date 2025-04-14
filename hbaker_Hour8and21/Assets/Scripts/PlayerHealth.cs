using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;
    
    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        Debug.Log("Final Health Points: " + healthpoints);
    }

    int UsePotion(int health)
    {
        return health + 400;
    }
}
