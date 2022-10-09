using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChek : MonoBehaviour
{
    public int score;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            ScoreChek.api.GetScore();
        }

    }
    public void GetScore()
    {
        score++;

    }

    public static ScoreChek api;
    private void Awake()
    {
        if (api == null)
        {
            api = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
        
}

