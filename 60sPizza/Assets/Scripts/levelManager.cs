using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public GameObject[] pizzaObjects; // Leveldeki pizza objelerini tutan dizi
    public GameObject[] levelPanels;

    private Animator pizzaAnimator;
    private int currentLevel = 0;


    private void Start()
    {
        pizzaAnimator = pizzaObjects[currentLevel].GetComponent<Animator>();
        SetCurrentLevelPanel();
    }

    private void SetCurrentLevelPanel()
    {
        for (int i = 0; i < levelPanels.Length; i++)
        {
            if (i == currentLevel)
                levelPanels[i].SetActive(true);
            else
                levelPanels[i].SetActive(false);
        }
    }

    public void OnServeButtonClicked()
    {
        StartCoroutine(PlayAnimationAndSwitchPanel());
    }

    private IEnumerator PlayAnimationAndSwitchPanel()
    {
        pizzaAnimator.Play("pizzaVeMalzeme");

        yield return new WaitForSeconds(pizzaAnimator.GetCurrentAnimatorStateInfo(0).length);

        levelPanels[currentLevel].SetActive(false);
        currentLevel++;
        pizzaAnimator = pizzaObjects[currentLevel].GetComponent<Animator>();
        SetCurrentLevelPanel();
    }

}