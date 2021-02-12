using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    private Text levelText;


    public void Start()
    {
        levelText = GetComponent<Text>();
    }
    public void Update()
    {
        if (ScoreScript.scoreValue <= 100)
        {
            levelText.text = "LEVEL 1";
        }

        if (ScoreScript.scoreValue == 100)
        {
            levelText.text = "LEVEL 2" ;
        }

        if (ScoreScript.scoreValue == 250)
        {
            levelText.text = "LEVEL 3";
        }

        if (ScoreScript.scoreValue == 500)
        {
            levelText.text = "LEVEL 4";
        }

        if (ScoreScript.scoreValue == 1000)
        {
            levelText.text = "LEVEL 5";
        }

        if (ScoreScript.scoreValue == 1500)
        {
            levelText.text = "LEVEL 6";
        }

        if (ScoreScript.scoreValue == 2000)
        {
            levelText.text = "LEVEL 7";
        }

        if (ScoreScript.scoreValue == 2500)
        {
            levelText.text = "LEVEL 8";
        }

        if (ScoreScript.scoreValue == 3000)
        {
            levelText.text = "LEVEL 9";
        }

        if (ScoreScript.scoreValue == 3500)
        {
            levelText.text = "LEVEL 10";
        }

    }
}
