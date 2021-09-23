using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIguard : AIcontroller

{
    void Start()
    {
        //Starts In Idle
        ChangeType(AItypes.Idle);
    }

    void Update()
    {
 //if in Chase state
        if (currentType == AItypes.Chase)
        {
            DoChase();

            if (CurrentTypeIsGreaterThan(3))          
            {
                ChangeType(AItypes.Idle);
            }
              
        }
        else if (currentType == AItypes.Idle)
        {
            //check for transition     
            
            if (TankClose(GameManager.instance.players[0].pawn))
            {
                ChangeType(AItypes.Chase);
            }
        }

 //if in idle state
        if (currentType == AItypes.Idle)
        {
            DoIdle();

           //do nothing

        }

  //If in Flee
        if (currentType == AItypes.Flee)
        {
            DoFlee();
        
         if (CurrentTypeIsGreaterThan(3))
        
            ChangeType(AItypes.Idle);
 
        }
        
 //If in stop Shoot
        if (currentType == AItypes.StopAndShoot)
        {
            DoStopAndShoot();
            if (TankClose(GameManager.instance.players[0].pawn))
            {
                ChangeType(AItypes.Chase);
            }
        }

        
 //If in Chase and Shoot
        if (currentType == AItypes.ChaseShoot)
        {
            DoChaseAndShoot();

            if (TankClose(GameManager.instance.players[0].pawn))
            {
                ChangeType(AItypes.StopAndShoot);
            }
            //check for transition     

           else if (CurrentTypeIsGreaterThan(3))
            {
                ChangeType(AItypes.Idle);
            }
        }
 //if in Patrol
        if (currentType == AItypes.Patrol)
        {
            DoPatrol();

            if (TankClose(GameManager.instance.players[0].pawn))
            {
                ChangeType(AItypes.Chase);
            }

           else if (CurrentTypeIsGreaterThan(3))
            {
                ChangeType(AItypes.Patrol);
            }
        }
    }
}



