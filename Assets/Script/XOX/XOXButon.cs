using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class XOXButon : MonoBehaviour
{
    XOXGameManager gameManager;
    Image img;
    Button btn;
    


    public int x, y;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<XOXGameManager>();

        img = GetComponent<Image>();
        btn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
       
        img.sprite = gameManager.GetCurrentSideSprite();

        gameManager.ReportClick(x,y);

        btn.enabled = false;
        
        
    }

}
