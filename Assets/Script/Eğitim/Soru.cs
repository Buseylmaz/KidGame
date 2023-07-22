using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Soru 
{
    public string soruİsmi, cevapA, cevapB, cevapC, cevapD;
    public int cevap;

    public void Soru_(string soru,string cevap1,string cevap2,string cevap3,string cevap4,int cvp)
    {
        soruİsmi = soru;
        cevapA=cevap1;
        cevapB=cevap2;
        cevapC=cevap3;
        cevapD=cevap4;
        cevap = cvp;
    }
}
