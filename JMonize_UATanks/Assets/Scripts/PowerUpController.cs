using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public List<PowerUp> powerUps;
    private TankData data;


	// Use this for initialization
	void Start ()
    {
        powerUps = new List<PowerUp>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Expired PowerUp list
        List<PowerUp> expiredPowerups = new List<PowerUp>();

        // Looping through each PowerUp in our list
        foreach (PowerUp power in powerUps)
        {
            // Timer subtracting
            power.duration -= Time.deltaTime;

            // Making the list of expirec PowerUps
            if (power.duration <= 0)
            {
                expiredPowerups.Add(power);
            }
        }
        // After cycling through, remove expired PowerUps from list
        foreach (PowerUp power in expiredPowerups)
        {
            power.OnDeactivate(data);
            powerUps.Remove(power);
        }
        //Clear list of expired PowerUps
        expiredPowerups.Clear();
    }
    
    //Adding PowerUp on activation
    public void Add(PowerUp powerup)
    {
        powerup.OnActivate(data);
        powerUps.Add(powerup);

        if (!powerup.isPermanent)
        {
            powerUps.Add(powerup);
        }
    }

}
