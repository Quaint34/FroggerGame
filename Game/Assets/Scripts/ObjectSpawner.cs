using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab; // Prefab of the object to be spawned
    public float spawnInterval = 1f; // Interval between each spawn
    public float spawnYRange = 4f; // Range of y-axis where objects can spawn
    public float objectLifetime = 10f; // Lifetime of spawned objects before they expire

    private float spawnX = 0f; // Fixed x-coordinate for spawning

    private void Start()
    {
        // Call the SpawnObject function repeatedly based on spawnInterval
        InvokeRepeating(nameof(SpawnObject), 0f, spawnInterval);
    }

    private void SpawnObject()
    {
        spawnX = transform.position.x;
        // Generate a random y-position within the spawnYRange
        float spawnY = transform.position.y + Random.Range(-spawnYRange / 2f, spawnYRange / 2f);

        // Spawn the object at the fixed x-coordinate and randomized y-coordinate
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);
        Quaternion spawnRotation = Quaternion.Euler(0f, 0f, -90f); // Horizontal rotation for 2D objects

        GameObject newObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);

        // Set the object to destroy itself after objectLifetime seconds
        Destroy(newObject, objectLifetime);
    }

    // Draw a gizmo in the Unity editor to visualize the spawn area
    private void OnDrawGizmosSelected()
    {
        // Draw a wire cube to represent the spawn area
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(new Vector3(spawnX, transform.position.y, 0f), new Vector3(0.2f, spawnYRange, 0f));
    }
}
