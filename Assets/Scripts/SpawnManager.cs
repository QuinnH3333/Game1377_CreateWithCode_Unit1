using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] spawnVehicles; 
    [SerializeField] private Transform[] spawnTransforms;
    [SerializeField] private float spawnTimer = 0;
    [SerializeField] private float spawnCooldown = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        
        if (spawnTimer > spawnCooldown)
        {
            spawnTimer = 0;
            SpawnRandomPrefab();
        }
        
    }

    private void SpawnRandomPrefab()
    {
        int spawnTransformIndex = Random.Range(0, spawnTransforms.Length);
        int spawnVehiclesIndex = Random.Range(0,spawnVehicles.Length);

        Transform currentSpawner = spawnTransforms[spawnTransformIndex];
        Instantiate(spawnVehicles[spawnVehiclesIndex], currentSpawner.position, currentSpawner.rotation);
    }
}
