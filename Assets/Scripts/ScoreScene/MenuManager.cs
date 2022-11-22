using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text highScore;
    public Text yourScore;
    
    void Start()
    {
        highScore.text = PlayerPrefs.GetFloat("highScore").ToString();
        yourScore.text = PlayerPrefs.GetFloat("yourScore").ToString();

    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(0);
           
        }
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(1);
           
          
        }
    }
}
