using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimeout : MonoBehaviour {

    public float bulletTimer = 5.0f;
    float timer = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > bulletTimer)
        {
            Destroy(gameObject);
        }
    }
}
