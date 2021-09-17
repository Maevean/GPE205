using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    //Variables
    public GameObject Bullet;
    //Between Shots Timer
    public float ShotTimer =1.0f;
    //Shot Countdown Timer
    private float sCountDown;


    // Update is called once per frame
    void Start()
    {
        //time delay
        sCountDown = Time.time;
    }

   void Update()

        
         {
       //If time is ready on the next Jump press, shoot.
        if (Input.GetButtonDown("Jump") && Time.time >= sCountDown + ShotTimer)
        {
            //call on shoot function and reset
            Shoot();
            sCountDown = Time.time;
        }
      

    }
    //shoot function
    void Shoot()
    {
            Instantiate(Bullet, transform.position, transform.rotation);
    }

}
