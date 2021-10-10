using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcontroller : Controller


{
    //AI Movement types
    public enum AItypes { Idle, Chase, StopAndShoot, ChaseShoot, Flee, Patrol };
    //Selecting the Current AI type
    public AItypes currentType;
    //when this close to player
    public float closeness = 5;
    //pulling from TankData data
    private TankData data;
    //Pulling from TankMover mover
    private TankMover mover;
    public float timeEnteredCurrentType;
    public Transform[] waypoints;
    private int currentWaypoint = 0;
    private Transform tf;
    public float fleeDistance = 3;


  

    public void ChangeType (AItypes newType)
    {
        //Actual change type
        currentType = newType;

        timeEnteredCurrentType = Time.time;
    }


    //The Different AI types and movements
    public void DoIdle ()
    {
        //Do Nothing Each Frame Drop
    }

    public void DoChase ()
    {

        //Turn towards the player
        TurnTowards(GameObject.FindWithTag("Player"));
        //Moving Forward 
        pawn.mover.MoveForward();
        //Do chase "player"
        
    }
    //Stop and Shoot Movement
    public void DoStopAndShoot ()
    {
            TurnToPlayer();
        //pawn shoot
        pawn.shooter.Shoot();

            
    }

    public void DoChaseAndShoot ()
    {
        //Do Turn towards player
        TurnToPlayer();
        //pawn shoot
        pawn.shooter.Shoot();
        //Moving Forward 
        pawn.mover.MoveForward();
        //Do chase "player"
        //Shoot?
    }

    public void DoFlee()
    {
        TurnTowards(GameObject.FindWithTag("Waypoint"));
        pawn.mover.MoveForward();
        //TODO move towards flee point
    }

    public void DoPatrol()
    {

        TurnTowards(GameObject.FindWithTag("Waypoint3"));
        pawn.mover.MoveForward();

    }

    public void TurnTowards (Vector3 position)
    {
        //Find Vector that points from this object to the position
        Vector3 vectorToTarget = position - pawn.transform.position;

        //Find the rotation instructions that will cause me to look down that vector
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);

        //turn a little towards that goal. (just enough that when we run this every frame we move at pawn.data.turnSpeed degrees per second)
        pawn.transform.rotation = Quaternion.RotateTowards(pawn.transform.rotation, targetRotation, pawn.turnSpeed * Time.deltaTime);
       
    }

    public void TurnTowards (Transform transform)
    {
        TurnTowards(transform.position);
    }

   public void TurnToPlayer()
    {
        //pawn.mover.
        TurnTowards(GameManager.instance.players[0].pawn.transform);
    }

    public void TurnTowards (GameObject targetObject)
    {
        TurnTowards(targetObject.transform);
    }

    public bool TankClose (TankData tankCheck)
    {
        //Definition of close
        if (Vector3.Distance(pawn.transform.position, tankCheck.transform.position) <= closeness)
        {
            return true;       
        }
        else
        {
            return false;
        }
    }

    public bool CurrentTypeIsGreaterThan (float time)
    {
        //if the current time is > time
        if (Time.time > (timeEnteredCurrentType + time))
        {
            return true; 
        }
        else
        {
            return false;
        }
    }

   // Sees if we can move
    public bool CanMove(float speed)
    {
        //Sends out forwards
        RaycastHit hit;

        // If it hits
        if (Physics.Raycast(tf.position, tf.forward, out hit, speed))
        {
            //If it is not a player hit
            if (!hit.collider.CompareTag("Player"))
            {
               
                return false;
            }
        }
      
        return true;
    }

}
