using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Oyuncu : MonoBehaviour
{
    public GameObject patlamaEfekt;
    public GameObject oyuncuAtes;
    public UzaySavsiYönetici uzaySavasi;
   

    float simdikiCan = 100.0f;

    float hareketHizi = 5.0f;
    float atesHizi = 500.0f;

    public AudioSource oyuncu;


    
    void Update()
    {
        float tusGecisi = Input.GetAxis("Horizontal");//yatay tuş geçişi(sag sol)

        transform.Translate(tusGecisi*Time.deltaTime*hareketHizi, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AtesEt();
        }

    }
    void CanAzalt(float canAzalt)
    {
        simdikiCan -= canAzalt;

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
        oyuncu.Play();
        uzaySavasi.PaneliGöster();
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DüsmanAtes")
        {
            Destroy(collision.gameObject);
            CanAzalt(10.0f);
        }
    }


    void AtesEt()
    {
        GameObject yeniAtes = Instantiate(oyuncuAtes, transform.position, Quaternion.identity);
        yeniAtes.GetComponent<Rigidbody2D>().AddForce(Vector2.up * atesHizi);


        Destroy(yeniAtes, 3.0f);
    }


}
