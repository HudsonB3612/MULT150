using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }

    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }

    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }

    void Start()
    {
        int x = TakeDamageFromFireball();
        print("Player health after fixed damage: " + x);

        int y = TakeDamageFromFireball(25);
        print("Player health after 25 damage: " + y);

        int z = TakeDamageFromFireball(30, 50);
        print("Player health after applying 30 damage to 50 health: " + z);
    }
}
