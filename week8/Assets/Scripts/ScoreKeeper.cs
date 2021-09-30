using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public float pointPerPickup = 1;
    public float currentScore = 0;
    

    public float CurrentScore()
    {
        return currentScore;
    }

    public void IncreaseScore()
    {
        currentScore += pointPerPickup;
    }
}
