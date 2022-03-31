using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnaKupHitManager : MonoBehaviour
{
    public GameObject anaKup;
    public GameObject tryAgainPanel;
    public GameObject finishedPanel;
    public Toplayici toplayici;
    public int gemPuan;
    public GameObject gamePuanText;
    public AudioSource backgroundMusic;
    GameObject gem;
    public int level = 0;
    void Start()
    {
        gem = GameObject.Find("Gem 1");
    }
    void Update()
    {
        transform.position =Vector3.MoveTowards(transform.position,anaKup.transform.position,Time.time);
        if(anaKup.transform.position.x == 1)
        {
            level = 1;
        } 
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Engel")
        {
            backgroundMusic.Stop();
            Destroy(gamePuanText);
            Time.timeScale = 0;
            tryAgainPanel.SetActive(true);
        }
        if(other.gameObject.tag == "Gem")
        {
            Destroy(gem,0);
            gemPuan++;
        }
        if(other.gameObject.tag == "xEngel")
        {
            XEngelShort();
        }
        if(other.gameObject.tag == "2xEngel")
        {
            XEngelShort();
            toplayici.X2EngelPuan();
        }
        if(other.gameObject.tag == "3xEngel")
        {
            XEngelShort();
            toplayici.X3EngelPuan();
        }
        if(other.gameObject.tag == "4xEngel")
        {
            XEngelShort();
            toplayici.X4EngelPuan();
        }
        if(other.gameObject.tag == "5xEngel")
        {
            XEngelShort();
            toplayici.X5EngelPuan();
        }
        if(other.gameObject.tag == "6xEngel")
        {
            XEngelShort();
            toplayici.X6EngelPuan();
        }
        if(other.gameObject.tag == "7xEngel")
        {
            XEngelShort();
            toplayici.X7EngelPuan();
        }
        if(other.gameObject.tag == "Bitis")
        {
            level++;
            Time.timeScale = 0;
            gamePuanText.SetActive(false);
            finishedPanel.SetActive(true);
            backgroundMusic.Stop();
            toplayici.X8BitisPuan();
        }
    }
    void XEngelShort()
    {
        backgroundMusic.Stop();
        gamePuanText.SetActive(false);
        Time.timeScale = 0;
        tryAgainPanel.SetActive(true);
    }
    public void RetryButton()
    {
        switch (level)
        {
            case 0:
            SceneManager.LoadScene("Level 1");
            break;
            case 1:
            SceneManager.LoadScene("Level 2");
            break;
            case 2:
            SceneManager.LoadScene("Level 3");
            break;
        }
    }
    public void NextLevelButton()
    {
        switch (level)
        {
            case 1:
            SceneManager.LoadScene("Level 2");
            break;
            case 2:
            SceneManager.LoadScene("Level 3");
            break;
        }
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
