using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    public static ScoreManeger instance;
    public int _score = 0;
    public Text scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void AddScore(int points)
    {
        _score += points;
        Debug.Log(_score);
        scoreText.text = "Score: " + _score.ToString();
    }
}   

