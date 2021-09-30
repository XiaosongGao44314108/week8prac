using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject ScoreKeeper;
    public float currentScore;
    public Text scores;
    
    // Update is called once per frame
    void Update()
    {
        currentScore = ScoreKeeper.GetComponent<ScoreKeeper>().CurrentScore();
        ScoreUpdated(currentScore);
    }

    void ScoreUpdated (float score)
    {
        scores.text = "Points: " + score;
    }
}
