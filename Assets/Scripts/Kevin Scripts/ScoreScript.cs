using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public int currentScore;

    void Start()
    {
        scoreText = GameObject.Find("TotalScore").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        AddScore();
        
    }

    public void AddScore()
    {
        currentScore += 100;
        scoreText.text = "Score: " + currentScore;
    }
}
