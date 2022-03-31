using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject clickToPlayText;
    public GameObject tryAgainPanel;
    public AudioSource backgroundMusic;
    bool BasladiMi;
    public GameObject PuanText;
    int level;
    public AnaKupHitManager anaKupHitManager;

    void Awake()
    {
        this.GetComponent<AudioSource>();
        Time.timeScale = 0;
        BasladiMi = true;
        tryAgainPanel.SetActive(false);
    }
    void Update()
    {
        if(Input.touchCount >= 1 && BasladiMi == true)
        {
            PuanText.SetActive(true);
            backgroundMusic.Play();
            BasladiMi = false;
            Destroy(clickToPlayText,0);
            Time.timeScale = 1;
        }
        if(Input.GetMouseButtonDown(0) && BasladiMi == true)
        {
            PuanText.SetActive(true);
            backgroundMusic.Play();
            BasladiMi = false;
            Destroy(clickToPlayText,0);
            Time.timeScale = 1;
        }
    }
}
