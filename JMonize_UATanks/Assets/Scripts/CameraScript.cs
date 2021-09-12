using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //Player and Zoom
    public GameObject player;
    public float zoom = 12.0f;
	// Use this for initialization
	void Start ()
    {
        //Searching for tag "Player"
        player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update ()
    {
        //Camera position code
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + zoom, player.transform.position.z);
	}
}
