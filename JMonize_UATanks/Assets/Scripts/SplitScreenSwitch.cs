using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Working on split screen switch to full
public class SplitScreenSwitch : MonoBehaviour
{
   public Camera camera1, camera2;
    private bool isSplitScreen;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.L))
        {
            isSplitScreen = !isSplitScreen;
        }
	}

    public void SetSplitScreen()
    {
        if (isSplitScreen)
        {
            camera1.rect = new Rect(0f, 0f, .5f, 1f);
            camera2.rect = new Rect(.5f, 0f, .5f, 1f);
        }
        else
        {
            camera1.rect = new Rect(0f, 0f, 1f, 1f);
            camera2.rect = new Rect(0f, 0f, 0f, 0f);
        }
    }
}
