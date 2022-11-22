using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public static float score;
    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = score.ToString();
        PlayerPrefs.SetFloat("yourScore", score);
        if (score>PlayerPrefs.GetFloat("highScore") )
        {
            PlayerPrefs.SetFloat("highScore", score);
        }
    }
}
