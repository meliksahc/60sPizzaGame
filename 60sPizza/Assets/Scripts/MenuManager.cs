using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public TMP_Text _highscoretext;
    public TMP_Text _yourscoretext;
    public GameObject MadalyonBir;
    public GameObject Madalyoniki;
    public GameObject MadalyonUc;
    public GameObject Madalyondort;
    private int Deger;
    void Start()
    {
        _highscoretext.text = PlayerPrefs.GetInt("_highscore").ToString();
        _yourscoretext.text = PlayerPrefs.GetInt("_yourscore").ToString();
        string v = PlayerPrefs.GetInt("_highscore").ToString();
        int textToint = int.Parse(v);
        Deger = textToint + 0;

        if (Deger > 50 && Deger < 100)
        {
            MadalyonBir.SetActive(true);
        }
        if (Deger > 100 && Deger < 200)
        {
            MadalyonBir.SetActive(false);
            Madalyoniki.SetActive(true);
        }
        if (Deger > 200 && Deger < 300)
        {
            MadalyonBir.SetActive(false);
            Madalyoniki.SetActive(false);
            MadalyonUc.SetActive(true);
        }
        if (Deger > 300 && Deger < 1000)
        {
            MadalyonBir.SetActive(false);
            Madalyoniki.SetActive(false);
            MadalyonUc.SetActive(false);
            Madalyondort.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
