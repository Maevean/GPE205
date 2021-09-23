using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatController : MonoBehaviour
{
    //Testing Cheat Controller
    public PowerUpController powCon;
    public PowerUp cheatPowerup;

    // Use this for initialization
    void Start ()
    {
        if (powCon == null)
        {
            powCon = gameObject.GetComponent<PowerUpController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // If H and U are down and this is the first frame that E is pressed
        if (Input.GetKey(KeyCode.P))
        {
            // Add our powerup to the tank
            powCon.Add(cheatPowerup);
        }
    }
}
