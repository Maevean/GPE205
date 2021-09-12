using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : MonoBehaviour
{   
    //Thrusting bullet forward 
    public float thrust = 110.0f;


    // Use this for initialization
    void Start()
    
   
    {
        //Thrust bullet code
        GetComponent<Rigidbody>().AddForce(transform.forward * thrust, ForceMode.Impulse);

       
    }


}
