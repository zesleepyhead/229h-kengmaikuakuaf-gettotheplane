using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Update()
    {
        scoreText.text = "Star: " + score;
    }

    public void AddScore()
    {
        score += 1;
    }

    public int CheckScore()
    {
        return score;
    }
    
}
