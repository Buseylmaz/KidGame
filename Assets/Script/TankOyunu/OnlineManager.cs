using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Chat;
using Photon.Realtime;

public class OnlineManager : Photon.MonoBehaviour
{

    void Start()
    {
        PhotonNetwork.Instantiate("Oyuncu", Vector3.zero, Quaternion.identity, 0);
    }

}
