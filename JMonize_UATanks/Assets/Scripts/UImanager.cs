using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{

    public Text myTextBox;
    // Use this for initialization
    void Start()
    {
        myTextBox.text = "UATanks";
        myTextBox.color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeText()
    {
        myTextBox.text = "UATanks Game";
    }

    public void QuitGame()
    {
    Application.Quit();
        Debug.Log("Quit");
     }

    public void StartGame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }



    public void Options()
    {
        //TODO
    }

    public float MusicVolume;

    public void IncreaseMusicVol()
    {
        MusicVolume++;
    }

    public void LowerMusicVol()
    {
        MusicVolume--;
    }

}
