using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public float currentScore;
    public Text scores;
    
    // Update is called once per frame
    void Update()
    {
        currentScore = scoreKeeper.CurrentScore();
        ScoreUpdated(currentScore);
    }

    void ScoreUpdated (float score)
    {
        scores.text = "Points: " + score;
    }
}
