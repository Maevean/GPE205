using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : MonoBehaviour
{
    private TankData data;
    public float thrust = 1510.0f;//Thrusting bullet forward 
    public GameObject Bullet;//Between Shots Timer
    public float ShotTimer = 1.0f;//Shot Countdown Timer
    private float sCountDown;
    public Transform fireSpot;


    // Use this for initialization
    void Start()
    
   
    {
        //TankData Load and shot time
        data = GetComponent<TankData>();
        sCountDown = data.ShotTimer;
    }
    public void Update()
    {
        //countdown
        sCountDown -= Time.deltaTime;
    }

    //Instantiate Shooting
    public void Shoot()
    {
      if (sCountDown <=0)
        {
            GameObject theBullet = Instantiate(data.pfBullet, fireSpot.position, fireSpot.rotation) as GameObject;

            Bullet theBulletScript = theBullet.GetComponent<Bullet>();
            theBulletScript.bulletLife = data.bulletTimer; //The bullets timer lifespan
            theBulletScript.shooter = data;// Tank Data is the shooter
            theBulletScript.BulletDamage = data.damageTaken;

            //Bullet Force
            Rigidbody bulletsRB = theBullet.GetComponent<Rigidbody>();
            bulletsRB.AddForce(fireSpot.forward * data.bulletForce);

            sCountDown = data.ShotTimer; 
        }

    }
   
}
