using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PowerUp
{
    public float speedModifier;
    public float healthModifier;
    public float maxHealthModifier;
    public float fireRateModifier;

    //Variable for how long is the powerup?
    public float duration;
    //Variable for permanent powerup
    public bool isPermanent;

	// Use this for initialization
	void Start () {
		
	}
    public void OnActivate(TankData data)
    {
        data.speed += speedModifier;
        data.CurrentHealth += healthModifier;
        data.totalHealth += maxHealthModifier;
        data.ShotTimer += fireRateModifier;
    }

    public void OnDeactivate(TankData data)
    {
        data.speed += speedModifier;
        data.CurrentHealth += healthModifier;
        data.totalHealth += maxHealthModifier;
        data.ShotTimer += fireRateModifier;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
