using UnityEngine;
using System.Collections;

public class SpawnOverTimeScript : MonoBehaviour
{

    // Object to spawn
    [SerializeField]
    private GameObject spawnEnemy;

    [SerializeField]
    private GameObject spawnEShip;

    [SerializeField]
    private GameObject spawnPickUp;

    // Delay between spawns
    [SerializeField]
    private float spawnDelayEnemy = 2f;

    [SerializeField]
    private float spawnDelayEShip = 2f;

    [SerializeField]
    private float spawnDelayPickup = 2f;

    private Renderer ourRenderer;

    // Use this for initialization
    void Start()
    {

        ourRenderer = GetComponent<Renderer>();

        // Stop our Spawner from being visible!
        ourRenderer.enabled = false;

        // Call the given function after spawnDelay seconds, 
        // and then repeatedly call it after spawnDelay seconds.
        InvokeRepeating("SpawnEnemy", spawnDelayEnemy, spawnDelayEnemy);
        InvokeRepeating("SpawnEnemyShip", spawnDelayEShip, spawnDelayEShip);
        InvokeRepeating("SpawnPickUp", spawnDelayPickup, spawnDelayPickup);
    }

    void SpawnEnemy()
    {
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnEnemy, spawnPoint, Quaternion.identity);
    }

    void SpawnEnemyShip()
    {
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnEShip, spawnPoint, Quaternion.identity);
    }

    void SpawnPickUp()
    {
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnPickUp, spawnPoint, Quaternion.identity);
    }
}
