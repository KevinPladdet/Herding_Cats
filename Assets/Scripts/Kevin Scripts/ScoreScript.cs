using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public int currentScore;

    bool stopUpdating = true;

    void Start()
    {
        scoreText = GameObject.Find("TotalScore").GetComponent<TextMeshProUGUI>();
    }

    public void AddScore()
    {
        currentScore += 100;
        scoreText.text = "Score: " + currentScore;
    }

    public void SaveHighscore()
    {
        if (stopUpdating == true)
        {
            if (currentScore > PlayerPrefs.GetInt("ScoreOne"))
            {
                PlayerPrefs.SetInt("ScoreTwo", PlayerPrefs.GetInt("ScoreOne"));
                PlayerPrefs.SetInt("ScoreThree", PlayerPrefs.GetInt("ScoreTwo"));
                PlayerPrefs.SetInt("ScoreFour", PlayerPrefs.GetInt("ScoreThree"));
                PlayerPrefs.SetInt("ScoreFive", PlayerPrefs.GetInt("ScoreFour"));
                PlayerPrefs.SetInt("ScoreOne", currentScore);
                stopUpdating = false;
            }

            if (currentScore > PlayerPrefs.GetInt("ScoreTwo") && currentScore < PlayerPrefs.GetInt("ScoreOne"))
            {
                PlayerPrefs.SetInt("ScoreThree", PlayerPrefs.GetInt("ScoreTwo"));
                PlayerPrefs.SetInt("ScoreFour", PlayerPrefs.GetInt("ScoreThree"));
                PlayerPrefs.SetInt("ScoreFive", PlayerPrefs.GetInt("ScoreFour"));
                PlayerPrefs.SetInt("ScoreTwo", currentScore);
                stopUpdating = false;
            }

            if (currentScore > PlayerPrefs.GetInt("ScoreThree") && currentScore < PlayerPrefs.GetInt("ScoreTwo"))
            {
                PlayerPrefs.SetInt("ScoreFour", PlayerPrefs.GetInt("ScoreThree"));
                PlayerPrefs.SetInt("ScoreFive", PlayerPrefs.GetInt("ScoreFour"));
                PlayerPrefs.SetInt("ScoreThree", currentScore);
                stopUpdating = false;
            }

            if (currentScore > PlayerPrefs.GetInt("ScoreFour") && currentScore < PlayerPrefs.GetInt("ScoreThree"))
            {
                PlayerPrefs.SetInt("ScoreFive", PlayerPrefs.GetInt("ScoreFour"));
                PlayerPrefs.SetInt("ScoreFour", currentScore);
                stopUpdating = false;
            }

            if (currentScore > PlayerPrefs.GetInt("ScoreFive") && currentScore < PlayerPrefs.GetInt("ScoreFour"))
            {
                PlayerPrefs.SetInt("ScoreFive", currentScore);
                stopUpdating = false;
            }
        }
    }
}
