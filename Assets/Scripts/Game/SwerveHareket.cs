using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveHareket : MonoBehaviour
{
    private HareketSistemi hareketSistemi;
    [SerializeField]
    float swerveHizi = 0.5f;
    [SerializeField]
    float maxSwerveMiktari = 1f;
    float swerveMiktari;
    void Awake()
    {
        hareketSistemi = GetComponent<HareketSistemi>();
    }
    void Update()
    {
        swerveMiktari = Time.deltaTime * swerveHizi * hareketSistemi.xHareketi;
        swerveMiktari = Mathf.Clamp(swerveMiktari, -maxSwerveMiktari, maxSwerveMiktari);
        transform.Translate(swerveMiktari, 0, 0);
    }
}
