using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;


public class FindaRoom : Photon.MonoBehaviour
{
    //İki oyuncunun birbiriyle eşleşmesi için lazım olan script

    void Awake()
    {
        PhotonNetwork.autoJoinLobby = true;
        PhotonNetwork.ConnectUsingSettings("V2");
    }

    public void FindGameButton()
    {
        StartPairing();
        Debug.Log("Find Game");
    }

    public void StartPairing()//arama başlat
    {
        CancelInvoke("RequestJoind");
        requestCountLocal = 0;
        InvokeRepeating("RequestJoind", 0.1f, 0.1f);
    }

    public void StopPairing()
    {
        CancelInvoke("RequestJoind");
    }

    public int requestCountLocal;
    public int requestCount = 30; //3 saniye

    public void RequestJoind() //3 saniye içinde oda bulmazsa random bir isim veriyor
    {
        requestCountLocal += 1;
        Debug.Log(requestCountLocal > requestCount);

        if (requestCountLocal > requestCount)
        {
            PhotonNetwork.CreateRoom(Random.Range(0.0f, 33339.2f).ToString(), new RoomOptions() { MaxPlayers = 2 }, null);
            CancelInvoke("RequestJoind");
        }
        else
        {
            PhotonNetwork.JoinRandomRoom();
        }
    }

    public InputField ınput; //Oyuncu ismi
    public void OnJoinedRoom()
    {
        PhotonNetwork.playerName = ınput.text;
        PhotonNetwork.LoadLevel("TankOyunGiris");
    }

    public void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby");
    }

    public void GeriDon()
    {
        PhotonNetwork.LeaveLobby();
        SceneManager.LoadScene("OdaSecme");
    }

    public void OnJoinRandomFailed(short returnCode, string message)
    {
        if (requestCountLocal >= 30)
        {
            Debug.Log("Random error");
        }
    }

    public void OnLeftLobby()
    {
        PhotonNetwork.LeaveLobby();
    }

    public void TekrarDene()
    {
        SceneManager.GetActiveScene();
    }

    public void BackMain()
    {
        PhotonNetwork.LeaveLobby();
        SceneManager.LoadScene("SelectNumber");
    }

}