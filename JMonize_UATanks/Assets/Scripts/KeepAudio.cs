using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAudio : MonoBehaviour
    //Keeping Audio going between scenes
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
