using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Set Up Singleton
    public static GameManager instance;
    public List<TankData> tanks;
    public List<InputController> players;
    public InputController player1;
    public InputController player2;

    private void Awake()
    {
        //if there is already a singleton
        if (instance != null)
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

    void Start()
    {
        //Save me to Game Manager
        //GameManager.instance.tanks.Add(this); 
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDestroy()
    {
        //Remove me from list
        //GameManager.instance.tanks.Remove(this);       
    }

    public void BeginTwoPlayerGame()
    {
        //Do All stuff for two player game
        //Gen Map
        GenerateMap();
        //Spawn 1 player

        //player1 = SpawnPlayer();
        //Spawn 2 player

        //player2 = SpawnPlayer();

        //Spawn Enemy
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {

    }

    /*public InputController SpawnPlayer()
    {
        //Spawn player and return
        InputController newPlayerController;

         return newPlayerController;
    }*/

    public void GenerateMap()
    {

    }
}
