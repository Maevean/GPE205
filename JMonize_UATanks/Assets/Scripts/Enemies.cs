using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    //Enemy attacks
    public bool attack = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            attack = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            attack = false;
        }
    }
}