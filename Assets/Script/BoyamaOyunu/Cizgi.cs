using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Cizgi : MonoBehaviour
{
    public EdgeCollider2D ed;
    public LineRenderer lineRenderer;

    List<Vector2> sayi;

    public void UpdateLine(Vector2 mousepos)
    {
        if (sayi == null)
        {
            sayi = new List<Vector2>();
            SayiKaydet(mousepos);
            return;
        }
        if (Vector2.Distance(sayi.Last(), mousepos) > 0.1f)
        {
            SayiKaydet(mousepos);
        }
    }

    void SayiKaydet(Vector2 sayis)
    {
        sayi.Add(sayis);
        lineRenderer.positionCount = sayi.Count;
        lineRenderer.SetPosition(sayi.Count - 1, sayis);

        if (sayi.Count > 1)
        {
            ed.points = sayi.ToArray();
        }
    }
}
