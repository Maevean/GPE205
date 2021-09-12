using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour {
    //Enemey public health
    public int health = 3;

    // Update is called once per frame
    void Update()
    {
        //Destroy Enemy once no health left
        if (health < 1)
        {
            Destroy(gameObject.transform.root.gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {   
        //Destroying Bullet on impact
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            health--;
        }
        
    }
}

