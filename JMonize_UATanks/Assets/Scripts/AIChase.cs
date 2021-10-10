using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : AIcontroller

{
    void Start()
    {
        //Starts In Chase
        ChangeType(AItypes.Chase);
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

            if (TankClose(GameManager.instance.players[0].pawn) || CurrentTypeIsGreaterThan(3))
            {
                ChangeType(AItypes.Chase);
            }
        }

       
    }
}
