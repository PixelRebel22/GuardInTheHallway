using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject guard;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPlayer();

        //Sets the spawn position of the guard and spawns it
        Vector3 guardSpawnPosition = new Vector3(-30.66f, 2.4f, -8.15f);
        Instantiate(guard, guardSpawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer()
    {
        //Sets the spawn position and look rotation of the player and spawns it
        Vector3 spawnPosition = new Vector3(-8.2f, 4, 7.6f);
        Quaternion playerRotation = Quaternion.LookRotation(Vector3.right);
        Instantiate(player, spawnPosition, playerRotation);
        Debug.Log("Player Spawned");
    }
}
