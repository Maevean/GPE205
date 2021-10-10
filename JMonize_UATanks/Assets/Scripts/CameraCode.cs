using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCode : MonoBehaviour
{
    public Camera Cam;
	// Use this for initialization
	void Start ()
    {
        Cam.fieldOfView = 120;
        Cam.rect = new Rect(0, 0.5f, 0.5f, 1.0f);
        Cam.depth = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
