using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        //Destroying Bullet on Collision
        if (collision.gameObject.tag == "PlayerBullet")
        {
            Destroy(collision.gameObject);
        }
    }
}
