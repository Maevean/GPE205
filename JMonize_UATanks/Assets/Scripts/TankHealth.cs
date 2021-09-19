using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour
{
    private TankData data;

    private void Start()
    {
        //Get TankData data on start
        data = GetComponent<TankData>();
    }

    public void TakeDamage (float DamageAmount, TankData damageDealer)
    {
        //Taking Damage
        /*data.CurrentHealth =*/ data.CurrentHealth = DamageAmount;

        //Death Check
        if (data.CurrentHealth <=0)
        {
            Death(damageDealer);
        }
    }

    //On Death
    public void Death(TankData damageDealer)
    {
        //Destroy Me 
        Destroy(gameObject);

        //TODO Give Points to Damage Dealer
    }
}
