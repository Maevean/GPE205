using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public TankData shooter;
    public float BulletDamage;
    public float bulletLife;


    // Use this for initialization
    void Start ()
    {
        Destroy(gameObject, bulletLife);
	}

    //Grabbing othe objects health component
    public void OnTriggerEnter(Collider other)
    {
        //Hitting this object 
        GameObject otherObject = other.gameObject;

        //Doing damage to objects with TankHealth
        TankHealth otherHealth = otherObject.GetComponent<TankHealth>();
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(BulletDamage, shooter);
        }

        //Destroy myself on death
        Destroy(gameObject);
    }
}
