using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimeout : MonoBehaviour {

    public float bulletTimer = 3.0f;
    float timer = 0.0f;

    void Update()
    {
        //Timing out bullet in case of non collision.
        timer += Time.deltaTime;

        if (timer > bulletTimer)
        {
            Destroy(gameObject);
        }
    }
}
