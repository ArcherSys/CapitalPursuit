using UnityEngine;
using UnityStandardAssets._2D;
using System.Collections;
using Steer2D;

public class LevelSpawner : MonoBehaviour {
    public Platformer2DUserControl player;       // Reference to the player's heatlh.
public GameObject enemy;                // The enemy prefab to be spawned.
           // How long between each spawn.
public Transform[] levelPoints;         // An array of the spawn points this enemy can spawn from.
private int spawnPointIndex;

void Start()
{
    // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.

    spawnPointIndex = 0;
}

    public bool isPastLevel(int index)
    {
        return (player.transform.position.x > levelPoints[index].position.x);
    }
    public bool isAvoidable(int index)
    {
        return (player.transform.position.x - levelPoints[index].position.x <= 2);
    }
    void Update()
{
    // If the player has no health left...
    if (player == null)
    {
        // ... exit the function.
        return;
    }
   

    // Find a random index between zero and one less than the number of spawn points.

    if ( isPastLevel(spawnPointIndex))
    {
        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
       enemy = (GameObject) Instantiate(enemy, levelPoints[spawnPointIndex].position, levelPoints[spawnPointIndex].rotation);
            enemy.GetComponent<Pursue>().TargetAgent = player.gameObject.GetComponent<SteeringAgent>();
        spawnPointIndex++;
    }
}
}
