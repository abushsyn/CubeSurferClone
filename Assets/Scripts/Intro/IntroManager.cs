using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class IntroManager : MonoBehaviour
{
    GameObject blackTabLogo;
    void Start()
    {
        blackTabLogo = GameObject.Find("Blacktab");
        blackTabLogo.GetComponent<RectTransform>().DOMoveY(960,3).SetEase(Ease.OutBack);
        Invoke("Intro",3);
        Invoke("GameLoad",4);

    }
    void Intro()
    {
        blackTabLogo.GetComponent<RectTransform>().DOScale(0,2).SetEase(Ease.OutBack);
    }
    void GameLoad()
    {
        SceneManager.LoadScene("Level 1");
    }
}
