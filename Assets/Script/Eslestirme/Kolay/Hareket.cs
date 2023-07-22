using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    Camera kamera;
    GameObject[] eslestir;
    Vector2 baslangıcPozisyonu;
    Son sonScript;
    
    void Start()
    {
        kamera = GameObject.Find("Camera").GetComponent<Camera>();
        eslestir = GameObject.FindGameObjectsWithTag("esles");
        baslangıcPozisyonu = transform.position;
        sonScript = GameObject.Find("Son").GetComponent<Son>();
    }

    void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition); //dokundugumuz yerin bilğisini verir.
        pozisyon.z = 0;
        transform.position = pozisyon;
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            foreach (GameObject esles in eslestir)
            {
                if (gameObject.name == esles.name)
                {
                    float mesafe = Vector3.Distance(esles.transform.position, transform.position);
                    
                    if (mesafe <= 0.4)
                    {
                        transform.position = esles.transform.position;
                        Destroy(this);
                        sonScript.LevelSon();
                    }
                    else
                    {
                        transform.position = baslangıcPozisyonu;
                    }
                }
            }
        }
    }
}
