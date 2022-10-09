using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreShow : MonoBehaviour
{
    [SerializeField] Text scoreText;
    public void Update()
    {
        scoreText.text = ScoreChek.api.score.ToString();
    }

}
