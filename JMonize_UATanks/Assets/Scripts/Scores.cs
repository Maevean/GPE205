using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public static Scores instance;

    public Text scoresText;
    public Text highScoresText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        //showing high score and score text
        scoresText.text = score.ToString() + " Points";
        highScoresText.text = "High Score: " + highscore.ToString();
    }

    public void AddPoints()
    {
        //adding 1 point
        score += 1;
        scoresText.text = score.ToString() + " Points";
        if (highscore < score)
        //Saving High score
        PlayerPrefs.SetInt("highscore", score);
    }
}
