using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Set Up Singleton
    public static GameManager instance;
    public List<TankData> tanks;
    public List<InputController> players;
    

    private void Awake()
    {
        //if there is already a singleton
        if (instance !=null)
        {
            //Get rid of other game object
            Destroy(gameObject);       
        }
        else
        //then use this object
        {
            instance = this;
        }
    }

    void Start ()
    {
        //Save me to Game Manager
       //GameManager.instance.tanks.Add(this); 
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnDestroy()
    {
        //Remove me from list
      //GameManager.instance.tanks.Remove(this);       
    }
}
