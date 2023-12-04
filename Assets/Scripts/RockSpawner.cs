using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    // We want to spawn a rock at a random spawn point
    // when the player runs into this trigger area

    // Need a reference to the FALLING ROCK
    [SerializeField] private GameObject fallingRockPrefab;

    // Need a location (i.e. reference to the SPAWN POINTS)
    // Week 6 in the slides: LISTS
    [SerializeField] private List<GameObject> rockSpawnPoints = new List<GameObject>();
    [SerializeField] private List<Rock> rocks = new List<Rock>();

    // Need a reference to the COLLISION of the player
    private void OnTriggerEnter(Collider other)
    {
        // if the player goes into the trigger
        if (other.CompareTag("Player") == true)
        {
            Debug.Log("collision");

            // spawn a falling rock at a random spawn point
            Vector3 spawnPosition = rockSpawnPoints[Random.Range(0, rockSpawnPoints.Count)].transform.position;

            // check that the variable is not null
            if(fallingRockPrefab != null)
            {
                // spawn the falling rock!
                GameObject newRock = Instantiate(fallingRockPrefab, spawnPosition, Random.rotation);

                rocks.Add(newRock.GetComponent<Rock>());

                foreach (Rock rock in rocks)
                {
                    rock.name = "Aaron's Falling Rock";
                }
            }
        }
    }
}
