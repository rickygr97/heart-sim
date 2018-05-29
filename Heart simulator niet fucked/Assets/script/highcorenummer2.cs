using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class highcorenummer2 : MonoBehaviour {


    public static int score;
    public static int highscores;
    Text text;
    public Text highscoretext;
    void Start()
    {
        text = GetComponent<Text>();

        score = 0;

        highscores = PlayerPrefs.GetInt("highscore");
        highscoretext.text = highscores.ToString();
    }

    void Update()
    {
        text.text = "" + score;

        if (score > highscores)
        {
        highscores = score;

                PlayerPrefs.SetInt("highscore", highscores);
        }
        
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void Reset()
    {
        score = 0;
    }
}
