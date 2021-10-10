using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFlee : AIcontroller

{
    void Start()
    {
        //Starts In Idle
        ChangeType(AItypes.Flee);
    }

    void Update()
    {
        //If in Flee
        if (currentType == AItypes.Flee)
        {
            DoFlee();

            if (CurrentTypeIsGreaterThan(3))

                ChangeType(AItypes.Idle);

        }
        //if in idle state
        if (currentType == AItypes.Idle)
        {
            DoIdle();
            if (CurrentTypeIsGreaterThan(3))

                ChangeType(AItypes.Flee);
            //do nothing

        }

    }
}
