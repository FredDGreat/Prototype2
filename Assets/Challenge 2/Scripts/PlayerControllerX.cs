using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //this variable is used to check when a dog is spawned
    public bool isDogSpawned = false;
    private float leastBallSpawnInterval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //Bonus
        //allow user to spawn dog every 3 seconds. This will stop frequent spawning of dog by the user.
        InvokeRepeating("UserCanSpawnDog", 0, leastBallSpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //once isDogSpawned is enabled, user can't spawn dog within the next 3 seconds
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !isDogSpawned)
        {
            isDogSpawned = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
    /**
     * This method enables dog spawning
     */
    void UserCanSpawnDog()
    {
        isDogSpawned = false;
    }
}
