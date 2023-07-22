using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resim : MonoBehaviour
{
    [SerializeField] GameObject imageBox;
    [SerializeField] GameController gameController;
    
    public void OnMouseDown()
    {
        if(imageBox.activeSelf && gameController.CanOpen)
        {
            imageBox.SetActive(false);
            gameController.ImageOpened(this);
        }
    }


    int spriteId;
    public int SpriteId
    { 
        get
        {
            return spriteId;
        }
    }

    public void ChangeSprite(int id,Sprite image)
    {
        spriteId = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Close()
    {
        imageBox.SetActive(true); 
    }

}
