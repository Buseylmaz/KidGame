using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Chat;
using Photon.Realtime;
using UnityEngine.PlayerLoop;

public class KasmaSorunu : Photon.MonoBehaviour
{
    Vector3 position;//rakip için
    Quaternion rotation;//rakip dönüş
    float gecikme = 8;

    void Update()
    {
        if (!photonView.isMine)
        {
            transform.position = Vector3.Lerp(transform.position, position, gecikme * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, gecikme * Time.deltaTime);
        }
    }

    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        {
            position = (Vector3)stream.ReceiveNext();
            rotation = (Quaternion)stream.ReceiveNext();
        }
    }
}