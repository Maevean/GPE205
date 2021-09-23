using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //Grabbing from PowerUp script
    public PowerUp powerUp;
    //adding audio for pickup
    public AudioClip feedback;
    public GameObject pickupPrefab;
    public float DelaySpawn;
    private float nextSpawnTime;
    private Transform tf;


    public void OnTriggerEnter(Collider other)
    {
        // Variable to store PowerUp controller, if there is one
        PowerUpController powCon = other.GetComponent<PowerUpController>();

        // If other tank has power up
        if (powCon != null)
        {
            // Add the powerup
            powCon.Add(powerUp);

            // Play feedback clip
            if (feedback != null)
            {
                AudioSource.PlayClipAtPoint(feedback, tf.position, 1.0f);
            }

            // Destroy this pickup
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start ()
    {
        tf = gameObject.GetComponent<Transform>();
        nextSpawnTime = Time.time + DelaySpawn;
    }
	
	// Update is called once per frame
	void Update ()
    {
        // If it is there is nothing spawns
      /*  if (spawnedPickup == null)
        {
            // And it is time to spawn
            if (Time.time > nextSpawnTime)
            {
                // Spawn it and set the next time
                spawnedPickup = Instantiate(pickupPrefab, tf.position, Quaternion.identity) as GameObject;
                nextSpawnTime = Time.time + DelaySpawn;
            }
        }
        else
        {
            // Otherwise, the object still exists, so postpone the spawn
            nextSpawnTime = Time.time + DelaySpawn;
        }*/
    }
}
