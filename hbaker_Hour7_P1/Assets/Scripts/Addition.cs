using UnityEngine;

public class Addition : MonoBehaviour
{
    void Start()
    {
        int a = 2;
        int b = 4;
        int c = 8;
        int sum = a + b + c;
        
        sum++;
        
        print(sum);
    }
}