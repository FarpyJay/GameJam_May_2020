using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score = 0;

    public static int highscore;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        //highscore = PlayerPrefs.GetInt("highscore", highscore);
    }

    void Update()
    {

        text.text = "Score: " + score.ToString();

        //PlayerPrefs.SetInt("highscore", highscore);
    }

    public static void AddPoints(int points)
    {
        score += points;
    }
}
