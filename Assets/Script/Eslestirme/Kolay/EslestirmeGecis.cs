using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EslestirmeGecis : MonoBehaviour
{
    public void EslestirmeKolay(int sahneid)
    {

        SceneManager.LoadScene(11);
    }
    public void EslestirmeOrta(int sahneid)
    {

        SceneManager.LoadScene(12);
    }
    public void EslestirmeZor(int sahneid)
    {

        SceneManager.LoadScene(13);
    }

    public void EslestirmeAnaMenü(int sahneid)
    {

        SceneManager.LoadScene(10);
    }

    public void AnaMenü(int sahneid)
    {

        SceneManager.LoadScene(0);
    }
}
