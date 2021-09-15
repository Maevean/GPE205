using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpletonManager : MonoBehaviour
{

    public static SimpletonManager Instance { get; private set; }

    public int Value;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}