using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class delayScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.Wait(5f, () =>
        {
            Debug.Log("SahneYükleniyor");
            SceneManager.LoadScene(2);
        });
    }
    
}
