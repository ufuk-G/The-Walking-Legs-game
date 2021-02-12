using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    private Text scoreText;
    

    public void Start()
    {
        scoreText = GetComponent<Text>();
    }
    public void Update()
    {
        AddScore();
    }

    public void AddScore()
    { 
        scoreText.text = "" + scoreValue;
    }



}
