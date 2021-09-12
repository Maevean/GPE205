using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : Controller
{
    public enum ControlType{ WASD };
    public ControlType controls;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Player Controls
		if (controls == ControlType.WASD)
        {
            if (Input.GetKey(KeyCode.W))
            {
                //Forward movement
                pawn.mover.MoveForward();
            }
            if (Input.GetKey(KeyCode.S))
            {
                //Backward movement
                pawn.mover.MoveBackward();
            }
            if (Input.GetKey(KeyCode.A))
            {
                //Backward movement
                pawn.mover.RotateLeft();
            }
            if (Input.GetKey(KeyCode.D))
            {
                //Backward movement
                pawn.mover.RotateRight();
            }
            {
                //Backward movement
                
            }
         
        } 
	}
}
