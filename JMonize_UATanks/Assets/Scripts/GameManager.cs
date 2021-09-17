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
            Destroy(gameObject);       
        }
        else
        //then this is the instance
        {
            instance = this;
        }
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
