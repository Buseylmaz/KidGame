using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasi : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangicPozisyon;
   

    GameObject[] kutuDizisi;

    Yönetici yönetici;

    private void OnMouseDrag() //Taşıma işleminde çalışan bir fonksiyon
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }

    // Start is called before the first frame update
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangicPozisyon = transform.position;

        kutuDizisi = GameObject.FindGameObjectsWithTag("Kutu");

        yönetici = GameObject.Find("PuzzleYönetici").GetComponent<Yönetici>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonUp(0))
        {
            foreach(GameObject kutu in kutuDizisi)
            {
                if (kutu.name == gameObject.name)
                {
                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);

                    if (mesafe <= 1)
                    {
                        transform.position = kutu.transform.position;
                        yönetici.SayıArttir();
                        this.enabled = false;
                    }
                    else
                    {
                        transform.position = baslangicPozisyon;
                    }
                }
            }
        }
    }
}