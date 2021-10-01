using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        scoreKeeper.IncreaseScore();
        Destroy(this.gameObject);

    }
}
