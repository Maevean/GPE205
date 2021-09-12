using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public GameObject Bullet;
    public float delayed = 1.0f;
    public GameObject enemyGroup;
    public Enemies EnemiesScript;
	// Use this for initialization
	void Start ()
    {

        enemyGroup = gameObject.transform.root.gameObject;
        EnemiesScript = enemyGroup.GetComponentInChildren<Enemies>();
		
	}

    // Attack time and delay
    void Update()
    {
        delayed = Mathf.Clamp01(delayed);

        if (delayed > 0.0f)
        {
            delayed -= Time.deltaTime;
        }

        if (delayed < 0.01f)
        {
            delayed = 1.0f;
        }
        if (EnemiesScript.attack && delayed == 1.0f)
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
