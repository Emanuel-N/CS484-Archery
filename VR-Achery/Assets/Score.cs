using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    
    private int yellow = 10;
    private int red = 5;
    private int blue = 3;
    private int black = 2;
    private int white = 1;
    public TextMeshProUGUI scoreText;

    private GameObject scoreManager;
    private GameObject text;

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Score Manager");
        text = GameObject.FindGameObjectWithTag("text");

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Yellow"))
        {
            scoreManager.GetComponent<ScoreManager>().score += yellow;
            SetCountText();
        }
        if (collision.gameObject.CompareTag("Red"))
        {
            scoreManager.GetComponent<ScoreManager>().score += red;
            SetCountText();
        }
        if (collision.gameObject.CompareTag("Blue"))
        {
            scoreManager.GetComponent<ScoreManager>().score += blue;
            SetCountText();
        }
        if (collision.gameObject.CompareTag("Black"))
        {
            scoreManager.GetComponent<ScoreManager>().score += black;
            SetCountText();
        }
        if (collision.gameObject.CompareTag("White"))
        {
            scoreManager.GetComponent<ScoreManager>().score += white;
            SetCountText();
        }

    }

    void SetCountText()
    {
        scoreText = text.GetComponent<TextMeshProUGUI>();
        scoreText.text = scoreManager.GetComponent<ScoreManager>().score.ToString();
    }
}
