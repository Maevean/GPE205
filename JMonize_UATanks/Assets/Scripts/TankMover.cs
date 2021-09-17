using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{
    //New *** 
    private TankData data;
    public Rigidbody rb;
    //public TankData data;

	// Use this for initialization
	void Start ()
    {
        //NEW*****
        data = GetComponent<TankData>();

        //Load Rigid Body
        rb = this.gameObject.GetComponent<Rigidbody>();    
        // OLD *** 
        //data = this.gameObject.GetComponent<TankData>();
		
	}

    // Moving speed and direction
    

    void Update () {
		
	}
    //Moving Forwards and speed
    public void MoveForward()
    {
        rb.MovePosition(rb.position + (transform.forward * data.speed * Time.deltaTime) );
    }
    //Moving Backwards and speed
    public void MoveBackward()
    {
        rb.MovePosition(rb.position + (-transform.forward * data.speed * Time.deltaTime));
    }
    //Rotation Left and speed
    public void RotateLeft()
    {
        transform.Rotate(0, -data.turnSpeed * Time.deltaTime, 0);
    }
    //Rotation Right and speed
    public void RotateRight()
    {
        transform.Rotate(0, data.turnSpeed * Time.deltaTime, 0);
    }

    public void RotateTowards()
    {
        //TODO Vector3 rotate towards object might go in tank data instead
    }
}
