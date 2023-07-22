using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Düsman : MonoBehaviour
{
    public Transform oyuncu;
    public GameObject patlamaEfekt;
    public GameObject düsmanAtes;
    UzaySavsiYönetici savsiYönetici;

   
    

    float simdikiCan = 100.0f;

    float hareketHizi =5.0f;
    float atesHizi = 500.0f;

    float atesAraligi = 0.8f;
    float atesZaman = 0.0f;

    public AudioSource düsman;



    void Update()
    {
        if (transform.position.x < oyuncu.position.x)
        {
            transform.Translate(hareketHizi * Time.deltaTime, 0, 0);
        }

        if (transform.position.x > oyuncu.position.x)
        {
            transform.Translate(-hareketHizi * Time.deltaTime, 0, 0);
        }

        if (oyuncu.position.x - transform.position.x <= 0.8f)
        {
            if (Time.time >= atesZaman)
            {
                AtesEt();
                atesZaman = Time.time + atesAraligi;
            }

        }
    }

    void AtesEt()
    {
        GameObject yeniAtes = Instantiate(düsmanAtes, transform.position, Quaternion.identity);
        yeniAtes.GetComponent<Rigidbody2D>().AddForce(Vector2.down * atesHizi);

        Destroy(yeniAtes, 3.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OyuncuAtes")
        {
            Destroy(collision.gameObject);
            CanAzalt(10.0f);
        }
    }


    void CanAzalt(float eksilenCan)
    {
        simdikiCan -= eksilenCan;

        if (simdikiCan <= 0)
        {
            YokOl();
        }

    }

    void YokOl()
    {
        Destroy(gameObject);
        GameObject yeniEfekt = Instantiate(patlamaEfekt, transform.position, Quaternion.identity);

        Destroy(yeniEfekt, 2.0f);
        düsman.Play();


        savsiYönetici.PaneliGöster2();



    }

    
   



}
