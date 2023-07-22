using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yönetici : MonoBehaviour
{
    int yerlestirilenParca = 0;
    public int toplamPuzzle;
    

    public Text textGameEnd;

    void Start()
    {
        
       
    }
    public void SayıArttir()
    {
        yerlestirilenParca++;

        if (yerlestirilenParca == toplamPuzzle)
        {
            textGameEnd.text = " OYUN BİTTİ";
            
            
        }
    }


    
}
