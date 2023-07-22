using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Random resimler oluşturmak için

    [SerializeField] const int columns=6;
    [SerializeField] const int rows = 2;

    [SerializeField] float Xspace,Yspace;

    [SerializeField] Resim startObject;
    [SerializeField] Sprite[] images;

    private int[] Randomiser(int[] locations)
    {
        int[] array=locations.Clone() as int[];

        for(int i=0; i<array.Length; i++) 
        { 
            int newArray = array[i];
            int j=Random.Range(i,array.Length);
            array[i] = array[j];
            array[j]= newArray;
        }
        return array;
    }

    void Start()
    {
        int[] locations = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        locations = Randomiser(locations);

        Vector3 startPosition = startObject.transform.position;

        for (int i = 0; i < columns; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                Resim gameImage;
                if(i==0 && j == 0)
                {
                    gameImage = startObject;
                }
                else
                {
                    gameImage=Instantiate(startObject) as Resim;

                }
                int index = j * columns + i;
                int id = locations[index];
                gameImage.ChangeSprite(id, images[id]);

                float positionX=(Xspace*i)+startPosition.x;
                float positionY = (Yspace * j) + startPosition.y;

                gameImage.transform.position=new Vector3(positionX, positionY, startPosition.z);
            }
        }
    }

    Resim firstOpen;
    Resim secondOpen;

    int score = 0;
    int attempts = 0;

    [SerializeField] Text scoreText;
    [SerializeField] Text attemptsText;

    public bool CanOpen
    {
        get 
        { 
            return secondOpen == null;
        }
    }

    public void ImageOpened(Resim startObject)
    {
        if (firstOpen == null)
        {
            firstOpen = startObject;
        }
        else
        {
            secondOpen = startObject;
            StartCoroutine(CheckGuessed());
        }
    }

    IEnumerator CheckGuessed()
    {
        if(firstOpen.SpriteId==secondOpen.SpriteId) //compares the two objects
        {
            score += 10;
            scoreText.text = " Skor: " + score;
        }
        else
        {
            yield return new WaitForSeconds(0.5f); //start timer
            firstOpen.Close();
            secondOpen.Close();
        }

        attempts += 1;
        attemptsText.text = " Adım: " + attempts;


        firstOpen = null;
        secondOpen = null;
    }

    public void Restart()
    {
        SceneManager.LoadScene(12);
    }

    public void Restart2()
    {
        SceneManager.LoadScene(13);
    }
    public void Finish()
    {
        SceneManager.LoadScene(10);
    }
 }
