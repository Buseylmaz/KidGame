using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Chat;
using Photon.Realtime;
using UnityEngine.PlayerLoop;

public class Mermi : Photon.MonoBehaviour
{
    public int gonderenObje;
    void Start()
    {
        Destroy(this.gameObject, 10);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "oyuncu")
        {
            if (gonderenObje != collision.gameObject.GetComponent<PhotonView>().viewID)
            {
                //collision.gameObject.GetComponent<CanScript>().AtesGeldi();
                photonView.RPC("HasarVer", PhotonTargets.All, gonderenObje, collision.GetComponent<PhotonView>().viewID);
                //PhotonNetwork.Destroy(this.gameObject);
            }
        }
        if (collision.tag == "engel")
        {
            PhotonNetwork.Destroy(this.gameObject);
        }

    }

    [PunRPC]
    public void SenderID(int atanKisiID)
    {
        gonderenObje = atanKisiID;
    }



    [PunRPC]
    public void HasarVer(int vuranKisi, int hasarAlanKisi)
    {
        OffLineKontrol(vuranKisi, hasarAlanKisi);
    }




    public List<GameObject> allObje;
    public void OffLineKontrol(int vuranKisi_, int hasaralanKisi)
    {
        foreach (GameObject vurdugumuzKisi in Resources.FindObjectsOfTypeAll(typeof(GameObject)))
        {
            if (vurdugumuzKisi.GetComponent<PhotonView>())
            {
                allObje.Add(vurdugumuzKisi);
            }
            
        }
        for (int i = 0; i < allObje.Count; i++)
        {
            int newId = i;
            if (allObje[newId].GetComponent<PhotonView>().viewID == hasaralanKisi)
            {
                allObje[newId].GetComponent<OyuncuHareket>().AtesEt();
            }


        }

        Destroy(this.gameObject);
    }

}
