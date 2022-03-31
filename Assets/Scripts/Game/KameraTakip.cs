using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public GameObject hedef;
    public Vector3 mesafe;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, hedef.transform.position + mesafe, Time.deltaTime);
    }
}
