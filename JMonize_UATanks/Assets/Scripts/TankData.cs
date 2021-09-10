using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
    //The Tank part variables
    public TankMover mover;
    public TankShooter shooter;
    //In Game Tank Variables
    public float speed;
    public float turnSpeed;

	// Use this for initialization
	void Start ()
    {
        //Mover Load
        mover = this.gameObject.GetComponent<TankMover>();
        //Shooter Load
        shooter = this.gameObject.GetComponent<TankShooter>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
