using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChaseandShoot : AIcontroller

{
    void Start()
    {
        //Starts In Idle
        ChangeType(AItypes.ChaseShoot);
    }

    void Update()
    {


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
                ChangeType(AItypes.ChaseShoot);
            }
        }
    }
}


