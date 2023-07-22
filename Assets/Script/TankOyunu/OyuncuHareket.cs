using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon;
using Photon.Chat;
using Photon.Realtime;
using UnityEngine.PlayerLoop;

public class OyuncuHareket : Photon.MonoBehaviour
{
    public Joystick joystick;
    float horizontal, vertical;

    public float oyuncuHiz;

    public GameObject mermiPrefab;
    public float mermiHizi;

    [HideInInspector] public Button atesEtButton;

    void Start()
    {
        if (photonView.isMine)
        {
            joystick = GameObject.Find("Fixed Joystick").GetComponent<FixedJoystick>();
            atesEtButton = GameObject.Find("AtesEt").GetComponent<Button>();
            atesEtButton.onClick.AddListener(() => AtesEt());
        }

    }


    void Update()
    {
        horizontal = joystick.Horizontal;
        vertical = joystick.Vertical;

        if (horizontal != 0 || vertical != 0)
        {
            this.transform.up = new Vector3(horizontal, -vertical, 0);
            this.transform.Translate(new Vector3(horizontal, vertical, 0) * oyuncuHiz, Space.World);
        }

    }


    public void AtesEt()
    {
        GameObject gelenAtes = PhotonNetwork.Instantiate("OyuncuAtes", this.transform.position, Quaternion.identity, 0);
        gelenAtes.GetComponent<PhotonView>().RPC("SenderID", PhotonTargets.All, photonView.viewID);
        gelenAtes.GetComponent<Rigidbody2D>().AddForce(-this.transform.up * mermiHizi);
    }










}
