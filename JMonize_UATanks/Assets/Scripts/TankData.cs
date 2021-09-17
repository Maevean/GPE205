using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
    //The Tank part variables
    public TankMover mover;
    public TankShooter shooter;
    //In Game Tank Variables
    public float speed;
    public float turnSpeed;
    //The Max Total Health
    public float totalHealth = 100;
    //Current Health
    public float CurrentHealth = 100;
    

    //NEW*** Bullet Prefab
    public GameObject pfBullet;
    //NEW*** Bullet Force
    public float bulletForce;

    public Rigidbody rb;
    public TankHealth health;

	// Use this for initialization
	void Start ()
    {

        GameManager.instance.tanks.Add(this);
        //NEW*** GetRB
        rb = GetComponent<Rigidbody>();
        //Mover Load
        mover = this.gameObject.GetComponent<TankMover>();
        //Shooter Load
        shooter = this.gameObject.GetComponent<TankShooter>();
        health = GetComponent<TankHealth>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        //remove me from list
        GameManager.instance.tanks.Remove(this);
    }


}
