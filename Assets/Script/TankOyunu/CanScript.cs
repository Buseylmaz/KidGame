using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Chat;
using Photon.Realtime;

public class CanScript : Photon.MonoBehaviour
{
    public int can = 100;
    public GameObject canlanma;
    public GameObject MainCamera;
    public CanlanmaScript canlanmaScript;

    void Start()
    {
        canlanma = GameObject.Find("YenidenDogma");

        if (photonView.isMine)//bizsek
        {
            MainCamera = this.transform.Find("Main Camera").gameObject;
            this.transform.Find("Main Camera").transform.parent = null;
        }
        else//rakipse
        {
            GetComponent<OyuncuHareket>().enabled = false; //rakibin hareketi kapansın
            Destroy(this.transform.Find("Main Camera").gameObject);
        }

        canlanmaScript = GameObject.Find("Canlanma").GetComponent<CanlanmaScript>();
    }
    public void AtesGeldi()
    {
        can -= 10;
        OlumKontrol();
    }


    public void OlumKontrol()
    {
        if (can <= 0 && photonView.isMine)
        {
            //Debug.Log("Bir düşman öldü");

            if (photonView.isMine)
            {
                canlanmaScript.CanlanmaOldu();
            }

            Destroy(MainCamera);
            PhotonNetwork.Destroy(this.gameObject);
        }
    }







}
