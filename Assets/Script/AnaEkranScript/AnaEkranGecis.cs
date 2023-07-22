using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaEkranGecis : MonoBehaviour
{
    //XOX
    public void XOXGiris(int sahneid)
    {

        SceneManager.LoadScene(1);
    }


    //PUZZLE
    public void PuzzleGiris(int sahneid)
    {

        SceneManager.LoadScene(2);
    }


    //UZAY SAVAŞI
    public void UzaySavasiGiris(int sahneid)
    {

        SceneManager.LoadScene(9);
    }


    //EŞLEŞTİRME
    public void EslestirmeOyunu(int sahneid)
    {

        SceneManager.LoadScene(10);
    }
    



    //EĞİTİM-MATEMATİK
    public void Matematik(int sahneid)
    {

        SceneManager.LoadScene(14);
    }

    //EĞİTİM-İNGİLİZCE
    public void İngilizce(int sahneid)
    {

        SceneManager.LoadScene(15);
    }

    //EĞİTİM-SORULAR
    public void Sorular(int sahneid)
    {

        SceneManager.LoadScene(16);
    }


    //TANK
    public void TankVurma(int sahneid)
    {

        SceneManager.LoadScene(21);
    }


   

    //ANA MENÜ DÖNÜŞ
    public void Cikis(int sahneid)
    {

        SceneManager.LoadScene(0);
    }


}
