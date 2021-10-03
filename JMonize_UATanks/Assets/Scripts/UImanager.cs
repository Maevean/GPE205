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
        //changing text and color
        myTextBox.text = "UATanks";
        myTextBox.color = Color.cyan;

        //Music volume settings
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Change Text Function
    public void ChangeText()
    {
        myTextBox.text = "UATanks Game";
    }

    //Quit Game Function
    public void QuitGame()
    {
    Application.Quit();
        Debug.Log("Quit");
     }

    //Start Game Function
    public void StartGame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }



    public void Options()
    {
        //TODO
    }

    //public AudioSource
    [SerializeField] Slider VolumeSlide;


    //Volume Slider Functions
    public void VolumeChange()
    {
        AudioListener.volume = VolumeSlide.value;
        Save();
    }
    
    //Player Music Prefs
    private void Load()
    {
        VolumeSlide.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("MusicVolume", VolumeSlide.value);
    }
    /*
     * Use for SFX?
     * public float MusicVolume;

    public void IncreaseMusicVol()
    {
        MusicVolume++;
    }

    public void LowerMusicVol()
    {
        MusicVolume--;
    }*/

}
