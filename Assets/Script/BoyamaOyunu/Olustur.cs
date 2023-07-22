using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olustur : MonoBehaviour
{
    public GameObject cizgiPrefab;
    Cizgi cizgiLine;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject cizgis = Instantiate(cizgiPrefab);
            cizgiLine = cizgis.GetComponent<Cizgi>();
        }

        if (Input.GetMouseButtonUp(0))
        {
            cizgiLine = null;
        }
        if (cizgiLine != null)
        {
            Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousepos.z = 0;
            cizgiLine.UpdateLine(mousepos);
        }
    }
}
