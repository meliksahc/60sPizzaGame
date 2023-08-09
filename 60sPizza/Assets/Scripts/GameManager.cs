using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Score skorvecan;
    public int _score;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        _score = skorvecan.scoreAmount;
        PlayerPrefs.SetInt("_yourscore", skorvecan.scoreAmount);
        if(_score > PlayerPrefs.GetInt("_highscore"))
        {
            PlayerPrefs.SetInt("_highscore", _score);
        }  
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
