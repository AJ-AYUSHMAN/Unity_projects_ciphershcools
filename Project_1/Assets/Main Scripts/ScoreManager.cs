using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManeger : MonoBehaviour
{
    public static ScoreManeger instance;
    public int _score = 0;

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
    }
}   

