using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : Controller
{
    public enum ControlType{ WASD, Arrows };
    public ControlType controls;



	// Use this for initialization
	void Start ()
    {
        //Adding me to list of players
        GameManager.instance.players.Add(this);
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
                //Rotate Left movement
                pawn.mover.RotateLeft();
              }
              if (Input.GetKey(KeyCode.D))
             {
                //Rotate Right movement
                pawn.mover.RotateRight();
              }
              //Shooting with left control
              if (Input.GetKey(KeyCode.LeftShift))
                {
                pawn.shooter.Shoot();
                 }
        else if (controls == ControlType.Arrows)
             {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    //Forward movement
                    pawn.mover.MoveForward();
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    //Backward movement
                    pawn.mover.MoveBackward();
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    //Rotate Left movement
                    pawn.mover.RotateLeft();
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    //Rotate Right movement
                    pawn.mover.RotateRight();
                }
                //Shooting with Right Control
                if (Input.GetKey(KeyCode.RightShift))
                {
                    pawn.shooter.Shoot();
                }
            }

        } 
	}
    public void OnDestroy()
    {
        GameManager.instance.players.Remove(this);
    }
}
