﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Çıkış Yapıldı");
        Application.Quit();
    }
}