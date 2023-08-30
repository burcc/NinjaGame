using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    Text scoreText;
    int highScore;
    public Text panelScore;
    public Text panelHighScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        panelScore.text = ("Score: " + score.ToString());
        highScore = PlayerPrefs.GetInt("highScore");
        panelHighScore.text = ("Best Score: " + highScore.ToString());
    }
    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
        panelScore.text = ("Score: " + score.ToString());
        if (score > highScore)
        {
            highScore = score;
            panelHighScore.text = ("Best Score: " + highScore.ToString());
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
