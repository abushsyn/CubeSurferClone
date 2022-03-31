using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toplayici : MonoBehaviour
{
    GameObject anaKup;
    int yukseklik;
    int puan;
    public Text puanText;
    public Text puanText2;
    public Text puanText3;
    public AudioSource cubeAl;
    void Start()
    {
        anaKup = GameObject.Find("AnaKüp");
    }

    void Update()
    {
        anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);

        puanText.text = puan.ToString();
        puanText2.text = puan.ToString();
        puanText3.text = puan.ToString();
    }
    public void YukseklikAzalt()
    {
        yukseklik--;
    }
    public void PuanAzalt()
    {
        puan--;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Topla" && other.gameObject.GetComponent<ToplanabilirKup>().GetToplandiMi() == false)
        {
            puan += 1;
            yukseklik += 1;
            other.gameObject.GetComponent<ToplanabilirKup>().ToplandiYap();
            other.gameObject.GetComponent<ToplanabilirKup>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKup.transform;
            cubeAl.Play();
        }
    }
    public void X2EngelPuan()
    {
        puan *= 2;
    }
    public void X3EngelPuan()
    {
        puan *= 3;
    }
    public void X4EngelPuan()
    {
        puan *= 4;
    }
    public void X5EngelPuan()
    {
        puan *= 5;
    }
    public void X6EngelPuan()
    {
        puan *= 6;
    }
    public void X7EngelPuan()
    {
        puan *= 7;
    }
    public void X8BitisPuan()
    {
        puan *= 8;
    }
}
