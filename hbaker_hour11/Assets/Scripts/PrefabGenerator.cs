using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public float spacing = 3.0f;

    void Start()
    {
         /*for (int i = 0; i < 10; i++)
         {
            Instantiate(prefab, transform.position, transform.rotation);
         }*/
        Vector3 spawnPosition = transform.position;

        for (int i = 0; i < 10; i++)
        {
            Vector3 currentLampPosition = spawnPosition + new Vector3(i * spacing, 0, 0); 
            Instantiate(prefab, currentLampPosition, transform.rotation);
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}