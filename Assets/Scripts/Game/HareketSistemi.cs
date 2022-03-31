using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketSistemi : MonoBehaviour
{
    float ilkPoz, sonPoz;
    public float xHareketi;
    public float ileriHizi;
    void Update()
    {
        transform.Translate(0, 0, ileriHizi * Time.deltaTime);
        if(Input.GetMouseButtonDown(0))
        {
            ilkPoz = Input.mousePosition.x;
        }
        else if(Input.GetMouseButton(0))
        {
            sonPoz = Input.mousePosition.x;
            xHareketi = sonPoz - ilkPoz;
        }
        if(Input.GetMouseButtonUp(0))
        {
            xHareketi = 0f;
        }
    }
}
