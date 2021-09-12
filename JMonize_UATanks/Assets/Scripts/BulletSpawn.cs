using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    //Variables
    public GameObject Bullet;
    public float timerDelay = 1.0f;
    private float lastEventTime;


    // Update is called once per frame
    void Start()
    {
        //time delay
        lastEventTime = timerDelay;
    }

    void Update()

    {


        //Using "jump" (spacebar) to fire
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(Bullet, transform.position, transform.rotation);

        }
        //shoot delay
        lastEventTime -= Time.deltaTime;
        if (lastEventTime <= 0)
        {
            Debug.Log("Not Ready Yet");
            lastEventTime = timerDelay;
        }


    }
}
