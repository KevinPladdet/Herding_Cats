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
        scoreOneText.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("ScoreOne").ToString();
        scoreTwoText.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("ScoreTwo").ToString();
        scoreThreeText.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("ScoreThree").ToString();
        scoreFourText.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("ScoreFour").ToString();
        scoreFiveText.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("ScoreFive").ToString();
    }
}
