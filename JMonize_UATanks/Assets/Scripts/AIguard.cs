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
    //if in idle state
        if (currentType ==AItypes.Idle)
        {
            DoIdle();

            if (TankClose(GameManager.instance.players[0].pawn))
            {
                ChangeType(AItypes.Chase);
            }
            
        }
        else if (currentType == AItypes.Chase)
        {
            DoChase();
            //check for transition     
            
            if (CurrentTypeIsGreaterThan (4))
            {
                ChangeType(AItypes.Idle);
            }
        }

       /* if (currentType == AItypes.Chase)
        {     
            DoChase();
            //TODO changestate: if no longer close do idle
        }

        if (currentType == AItypes.ChaseShoot)
        {
            DoChaseAndShoot();
        }

        if (currentType == AItypes.Flee)
        {
            DoFlee();      
        }

        if (currentType == AItypes.StopAndShoot)
        {
            DoStopAndShoot();
        }
        
        //check for transitions

    //else if i am in chase
        //do action for idle state
        //check for transitions*/
    }


}
