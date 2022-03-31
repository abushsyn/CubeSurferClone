using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToplanabilirKup : MonoBehaviour
{
    bool toplandiMi;
    int index;
    public Toplayici toplayici;
    AudioSource CubeBırak;
    void Start()
    {
        CubeBırak = GameObject.Find("Cubes").GetComponent<AudioSource>();
    }
    void Update()
    {
        if(toplandiMi == true)
        {
            if(transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    public bool GetToplandiMi()
    {
        return toplandiMi;
    }
    public void ToplandiYap()
    {
        toplandiMi = true;
    }
    public void IndexAyarla(int index)
    {
        this.index = index;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Engel")
        {
            toplayici.YukseklikAzalt();
            toplayici.PuanAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            CubeBırak.Play();
        }
    }
}
