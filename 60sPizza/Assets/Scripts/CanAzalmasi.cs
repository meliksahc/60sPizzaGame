using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanAzalmasi : MonoBehaviour
{
    public GameManager gameManager;
    public Text can;
    public int canDegeri;

    void Start()
    {
        canDegeri = 3;
        can = GetComponent<Text>();
    }
    private void Update()
    {
        can.text = canDegeri.ToString();
        if (canDegeri == 0)
        {
            gameManager.GameOver();
        }
    }
    public void CanAzalt()
    {
        canDegeri += -1;
    }
}