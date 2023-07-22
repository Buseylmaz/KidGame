using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanlanmaScript : MonoBehaviour
{
    public void CanlanmaOldu()
    {
        StartCoroutine(CanlanmaBekleme());
    }

    IEnumerator CanlanmaBekleme()
    {
        yield return new WaitForSeconds(3);
        PhotonNetwork.Instantiate("Oyuncu", Vector3.zero, Quaternion.identity, 0);
    }
}

