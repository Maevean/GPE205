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
       
        if (Input.GetButtonDown("Jump") && Time.time >= sCountDown + ShotTimer)
        {
            
            Shoot();
            sCountDown = Time.time;
        }
        //Using "jump" (spacebar) to fire
        /*if (Input.GetButtonDown("Jump")) 
        {
            Instantiate(Bullet, transform.position, transform.rotation);

        }*/

        //shoot delay


    }

    void Shoot()
    {
            Instantiate(Bullet, transform.position, transform.rotation);
    }

}
