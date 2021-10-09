﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MapGenerator : MonoBehaviour 

    {
        public int rows;
        public int cols;

        public int mapSeed;
        public float roomWidth = 50.0f;
        public float roomHeight = 50.0f;
        private Room[,] grid;
        public GameObject[] gridPrefabs;
        public bool isMapOfTheDay;
        public bool isMapSeed;
        public bool isRandom;
        
        

        // Use this for initialization
        void Start()
        {
         
        //Generate chosen map seed

            if (isMapSeed)
            {
            UnityEngine.Random.InitState(mapSeed);
            }
            if (isRandom)
            {
            UnityEngine.Random.InitState(DateToInt(DateTime.Now));
            }
             if (isMapOfTheDay)
             {
            mapSeed = DateToInt(DateTime.Now.Date);
             }

        // Generate Grid
            GenerateGrid();
        }

        public void GenerateGrid()
        {
            // Clear out the grid
            grid = new Room[rows, cols];

            // For each grid row...
            for (int i = 0; i < rows; i++)
            {
                // for each column in that row
                for (int j = 0; j < cols; j++)
                {
                    // Finding the location. 
                    float xPosition = roomWidth * j;
                    float zPosition = roomHeight * i;
                    Vector3 newPosition = new Vector3(xPosition, 0.0f, zPosition);

                    // Making a new grid at the right location
                    GameObject tempRoomObj = Instantiate(RandomRoomPrefab(), newPosition, Quaternion.identity) as GameObject;

                    // Set its parent
                    tempRoomObj.transform.parent = this.transform;

                    // Giving it a memorable name
                    tempRoomObj.name = "Room_" + j + "," + i;

                    // Get the room object
                    Room tempRoom = tempRoomObj.GetComponent<Room>();

                    // Open the doors
                    // If we are on the bottom row, open the north door
                    if (i == 0)
                    {
                        tempRoom.doorNorth.SetActive(false);
                    }
                    else if (i == rows - 1)
                    {
                        // Otherwise, if we are on the top row, open the south door
                        tempRoom.doorSouth.SetActive(false);
                    }
                    else
                    {
                        // Otherwise, we are in the middle, so open both doors
                        tempRoom.doorNorth.SetActive(false);
                        tempRoom.doorSouth.SetActive(false);
                    }
                    // If we are on the first column, open the east door
                    if (j == 0)
                    {
                        tempRoom.doorEast.SetActive(false);
                    }
                    else if (j == cols - 1)
                    {
                        // Otherwise, if we are on the last column row, open the west door
                        tempRoom.doorWest.SetActive(false);
                    }
                    else
                    {
                        // Otherwise, we are in the middle, so open both doors
                        tempRoom.doorEast.SetActive(false);
                        tempRoom.doorWest.SetActive(false);
                    }
                    // Save it to the grid array
                    grid[j, i] = tempRoom;
                }
            }
        }

        // Returns a random room
        public GameObject RandomRoomPrefab()
        {
            return gridPrefabs[UnityEngine.Random.Range(0, gridPrefabs.Length)];
        }
    public int DateToInt(DateTime dateToUse)
    {
        // Add up our date and return it
        return dateToUse.Year + dateToUse.Month + dateToUse.Day + dateToUse.Hour + dateToUse.Minute + dateToUse.Second + dateToUse.Millisecond;
    }
}
