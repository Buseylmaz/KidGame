using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geçiş : MonoBehaviour
{
    public AudioSource start;
    public void Anaokul(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(17);
    }
    public void İlkokul(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(18);
    }
    public void Ortaokul(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(19);
    }

    public void SorularTekrar(int sahneid)
    {
        SceneManager.LoadScene(16);
    }

    public void Cikis(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(14);
    }
    public void AnaMenü(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(0);
    }

    public void TekrarOyna(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(15);
    }

    public void TekrarOyna2(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(17);
    }

    public void TekrarOyna3(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(18);
    }

    public void TekrarOyna4(int sahneid)
    {
        start.Play();
        SceneManager.LoadScene(19);
    }


}
