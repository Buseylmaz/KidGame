using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleGecis : MonoBehaviour
{
    
    public void Kolay(int sahneid)
    {
       
        SceneManager.LoadScene(3);
    }

    public void Orta(int sahneid)
    {
        
        SceneManager.LoadScene(4);
    }

    public void Zor(int sahneid)
    {
        
        SceneManager.LoadScene(5);
    }

    public void Kolay2(int sahneid)
    {
        
        SceneManager.LoadScene(6);
    }

    public void Orta2(int sahneid)
    {
        
        SceneManager.LoadScene(7);
    }

    public void Zor2(int sahneid)
    {
        
        SceneManager.LoadScene(8);
    }

    public void Cıkıs(int sahneid)
    {
       
        SceneManager.LoadScene(2);
    }

    public void AnaEkran(int sahneid)
    {
       
        SceneManager.LoadScene(0);
    }

  
}
