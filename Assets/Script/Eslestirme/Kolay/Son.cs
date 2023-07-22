using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Son : MonoBehaviour
{
    [SerializeField]
    int toplamEs;
    [SerializeField]
    int ilkEs;

    public GameObject bittiPaneli;
    public Button anaMenü;



    public void LevelSon()
    {
        ilkEs += 1;
        if(ilkEs==toplamEs)
        {
            PaneliGöster();
        }
    }

    public void PaneliGöster()
    {
        bittiPaneli.SetActive(true);
        anaMenü.gameObject.SetActive(true);

        Time.timeScale = 0.0f;//oyunu durdurma
    }
}
