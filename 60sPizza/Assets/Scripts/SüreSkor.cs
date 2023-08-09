using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SüreSkor : MonoBehaviour
{
    private Text süre;
    private int SüreDegeri;
    public bool takingAway = false;
    public Score skorvecan;
    public GameManager gameManager;

    void Start()
    {
        SüreDegeri = 60;
        süre = GetComponent<Text>();
    }

    private void Update()
    {
        süre.text = SüreDegeri.ToString();
    
        if (takingAway == false && SüreDegeri > 0)
        {
            StartCoroutine(TimerTake());
        }
        if (SüreDegeri == 0)
        {
            gameManager.GameOver();
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        SüreDegeri -= 1;
        takingAway = false;
    }
    public void ServisButton()
    {
        if (SüreDegeri > 50)
        {
            skorvecan.SüreElliÜzeri();
        }
        if (SüreDegeri > 40 && SüreDegeri < 50)
        {
            skorvecan.SürekırkÜzeri();
        }
        if (SüreDegeri > 30 && SüreDegeri < 40)
        {
            skorvecan.SüreOtuzÜzeri();
        }
        if (SüreDegeri > 20 && SüreDegeri < 30)
        {
            skorvecan.SüreYirmiÜzeri();
        }
        if (SüreDegeri > 10 && SüreDegeri < 20)
        {
            skorvecan.SüreOnÜzeri();
        }
        if (SüreDegeri > 0 && SüreDegeri < 10)
        {
            skorvecan.SüreSıfırÜzeri();
        }

    }
}
