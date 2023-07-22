using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yarisma : MonoBehaviour
{
    public GameObject bittiPaneli;
    public GameObject kazandiPaneli;
    public GameObject yanlişPaneli;
    public Button tekrarOyna;
    public Button anaMenü;

    public Text soruİsmi, cevapA, cevapB, cevapC, cevapD,skorYazi;
    Sorular sr;

    public List<bool> sorulanlar;

    public int cevap,skor;
    

    void Start()
    {
        sr = GetComponent<Sorular>();
        for(int i = 0; i < sr.sorular.Count;  i++)
        {
            sorulanlar.Add(false);
        }
        SoruEkle();
        
    }


  

    public void SoruEkle()
    {
       
        for(int i=0; i< sorulanlar.Count; i++)
        {
            if (sorulanlar[i]==false)
            {
                int soruSayi = Random.Range(0, sorulanlar.Count);
                if (sorulanlar[soruSayi] == false)
                {
                    sorulanlar[soruSayi] = true;
                    skorYazi.text = "" + skor;
                    skor +=10;
                    
                   
                    soruİsmi.text = sr.sorular[soruSayi].soruİsmi;
                    cevapA.text = sr.sorular[soruSayi].cevapA;
                    cevapB.text = sr.sorular[soruSayi].cevapB;
                    cevapC.text = sr.sorular[soruSayi].cevapC;
                    cevapD.text = sr.sorular[soruSayi].cevapD;
                    cevap = sr.sorular[soruSayi].cevap;

                }
                else
                {
                    SoruEkle();
                }

                break;
            }
            if (i == sorulanlar.Count - 1)
            {
                PaneliGöster2();
            }
        }
        
        
    }


    public void CevapVer(int deger)
    {
        if(deger == cevap)
        {
            SoruEkle();
        }
        else
        {
            
            PaneliGöster();

        }
    }

    public void PaneliGöster()
    {
        bittiPaneli.SetActive(true);
        tekrarOyna.gameObject.SetActive(true);
        anaMenü.gameObject.SetActive(true);

        Time.timeScale = 0.0f;//oyunu durdurma
    }

    //public void PaneliGöster3()
    //{

    //    //yanlişPaneli.SetActive(true);
    //    StartCoroutine(TestCoroutine());
        

    //}

    //IEnumerator TestCoroutine()
    //{
    //    yanlişPaneli.SetActive(true);
    //    yield return new WaitForSeconds(2f);
    //    yanlişPaneli.SetActive(false);
       
    //}

    public void PaneliGöster2()
    {
        kazandiPaneli.SetActive(true);
        anaMenü.gameObject.SetActive(true);
        

        Time.timeScale = 0.0f;//oyunu durdurma
    }


}
