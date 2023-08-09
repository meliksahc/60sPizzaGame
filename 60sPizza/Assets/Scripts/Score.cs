using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public int scoreAmount;

    void Start()
    {
        scoreAmount = 0;
        score = GetComponent<Text>();
    }

    public void Update()
    {
        score.text = scoreAmount.ToString();

    }

    public void SkorArttır()
    {
        scoreAmount += 10;
    }

    public void SkorAzalt()
    {
        scoreAmount += -5;
       
    }

   
    public void SüreElliÜzeri()
    {
        scoreAmount += 35;
    }
    public void SürekırkÜzeri()
    {
        scoreAmount += 30;
    }
    public void SüreOtuzÜzeri()
    {
        scoreAmount += 25;
    }
    public void SüreYirmiÜzeri()
    {
        scoreAmount += 20;
    }
    public void SüreOnÜzeri()
    {
        scoreAmount += 15;
    }
    public void SüreSıfırÜzeri()
    {
        scoreAmount += 10;
    }

    public void MalzemeKonmamıs()
    {
        scoreAmount -= 35;
    }









}
