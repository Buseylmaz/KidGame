using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UzaySavsiYönetici : MonoBehaviour
{
    public GameObject bittiPaneli;
    public GameObject kazandın;
    public AudioSource start;
    public AudioSource start1;

    public Button tekrarOyna;
    public Button anaMenü;

    void Start()
    {
        start1.Play();
    }
    public void PaneliGöster()
    {
        bittiPaneli.SetActive(true);
        tekrarOyna.gameObject.SetActive(true);
        anaMenü.gameObject.SetActive(true);
        Time.timeScale = 0.0f;//oyunu durdurma
    }

    public void PaneliGöster2()
    {
        kazandın.SetActive(true);
        tekrarOyna.gameObject.SetActive(true);
        anaMenü.gameObject.SetActive(true);
        Time.timeScale = 0.0f;//oyunu durdurma
    }
    public void TekrarOyna()
    {
        start.Play();
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(9);

    }

 
}
