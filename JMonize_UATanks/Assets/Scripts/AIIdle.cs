using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIIdle : AIcontroller {

	// Use this for initialization
	void Start ()
    {
        //Starts In Idle
        ChangeType(AItypes.Idle);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if in idle state
        if (currentType == AItypes.Idle)
        {
            DoIdle();

            //do nothing

        }
    }
}
