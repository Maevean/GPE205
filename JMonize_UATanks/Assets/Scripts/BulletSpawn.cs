using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {

    public GameObject Bullet;

	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
		

	}
}
