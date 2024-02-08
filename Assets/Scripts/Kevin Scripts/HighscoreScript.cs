using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreScript : MonoBehaviour
{

    public GameObject scoreOneText;
    public GameObject scoreTwoText;
    public GameObject scoreThreeText;
    public GameObject scoreFourText;
    public GameObject scoreFiveText;

    public void setHighscores()
    {
        scoreOneText.GetComponent<TextMeshProUGUI>().text = "#1: " + PlayerPrefs.GetInt("ScoreOne").ToString();
        scoreTwoText.GetComponent<TextMeshProUGUI>().text = "#2: " + PlayerPrefs.GetInt("ScoreTwo").ToString();
        scoreThreeText.GetComponent<TextMeshProUGUI>().text = "#3: " + PlayerPrefs.GetInt("ScoreThree").ToString();
        scoreFourText.GetComponent<TextMeshProUGUI>().text = "#4: " + PlayerPrefs.GetInt("ScoreFour").ToString();
        scoreFiveText.GetComponent<TextMeshProUGUI>().text = "#5: " + PlayerPrefs.GetInt("ScoreFive").ToString();
    }
}
