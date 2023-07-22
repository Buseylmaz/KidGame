using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class XOXGameManager : MonoBehaviour
{
    public Sprite sprX, sprO;
    public XOXBoard currentBoard;
    public Side currentSide = Side.X;
    public Image imgCurrentSide;

    public GameObject goGameEnd;
    public Text textGameEnd;
    public Text skorText;

    public Text not;
    public AudioSource endMusic;
    


    bool DidGameEnd = false;

    static int skorX, skorO;

    public enum Side
    {
        Empty,
        X,
        O
    }

    
    void Start()
    {

        StartCoroutine(TestCoroutine());
        currentBoard = new XOXBoard();
        imgCurrentSide.sprite = GetCurrentSideSprite();

        goGameEnd.SetActive(false);

        UpdateSkorText();

    }

    void Update()
    {
        
        if (DidGameEnd)
        {
            if (Input.anyKeyDown)
            {
                string sceneName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    void UpdateSkorText()
    {
        skorText.text = skorX.ToString() + " - " + skorO.ToString();
    }

    public Sprite GetCurrentSideSprite()
    {
        if (currentSide == Side.X)
        {
            return sprX;
        }
        if (currentSide == Side.O)
        {
            return sprO;
        }

        return null;
    }

    void EndGame()
    {
        goGameEnd.SetActive(true);
        DidGameEnd = true;
        UpdateSkorText();
        endMusic.Play();
    }

    public void ReportClick(int x, int y)
    {
        
        currentBoard.Execute(x, y, currentSide);

        if (currentBoard.DidSideWinGame(currentSide))
        {

            textGameEnd.text = currentSide.ToString() + " KAZANDI";

            if (currentSide == Side.X)
            {
                skorX++;
            }
            else if (currentSide == Side.O)
            {
                skorO++;
            }

            EndGame();
            return;
        }

        if (!currentBoard.IsThereEmptyBox())
        {
            textGameEnd.text = " BERABERE";
            EndGame();
            return;
        }

        if (currentSide == Side.X)
        {
            currentSide = Side.O;
        }
        else
        {
            currentSide = Side.X;
        }

        imgCurrentSide.sprite = GetCurrentSideSprite();
    }

    IEnumerator TestCoroutine()
    {
        not.enabled = true ;
        yield return new WaitForSeconds(2f);
        not.enabled = false;
    }


}
