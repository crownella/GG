using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bedroommanager : MonoBehaviour
{
    GameManager gameManager;
    public bool clickone = false;



    public bool toyboxclosed = true;



    public AudioClip readbook;

    public AudioClip toyopen;
    public AudioClip toyclose;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        GameObject.FindGameObjectWithTag("Like Cars").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Robots").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Space").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Puzzles").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Animals").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Sports").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Music").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Toybox").GetComponent<SpriteRenderer>().enabled = false;

        GameObject.FindGameObjectWithTag("Like Cars").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Robots").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Space").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Puzzles").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Animals").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Sports").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Music").GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.collider.gameObject.tag == "Crib" && gameManager.napover == false)
                {

                    SceneManager.LoadScene("Crib");
                    Audio.me.PlaySound(readbook);

                    if(gameManager.toy3chosen == false)
                    {
                        gameManager.toy3chosen = true;
                    }


                }
                if (hit.collider.gameObject.tag == "Toybox")
                {
                    GameObject.FindGameObjectWithTag("Toybox").GetComponent<SpriteRenderer>().enabled = true;
                    Audio.me.PlaySound(toyopen);
                    toyboxclosed = false;
                    Invoke("Playtime", 1f);

                }

                if (hit.collider.gameObject.tag == "Diaper" && (gameManager.lunch == true || gameManager.napover == false))
                {

                    SceneManager.LoadScene("Diaper");
                }

                if (hit.collider.gameObject.tag == "Like Princesses")
                {
                    gameManager.ToyChoosing(gameManager.ToyPrincess);
                    gameManager.ToyChoice = gameManager.ToyPrincess;
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (gameManager.Princesses == true)
                    {
                        gameManager.Happinessmeter(.30f);
                       if( gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                }
                if (hit.collider.gameObject.tag == "Like Cars")
                {
                    gameManager.ToyChoice = gameManager.ToyCar;
                    gameManager.ToyChoosing(gameManager.ToyCar);
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (gameManager.Cars == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        if (gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                }
                if (hit.collider.gameObject.tag == "Like Alphabet")
                {
                    gameManager.ToyChoice = gameManager.ToyAlphabet;
                    gameManager.ToyChoosing(gameManager.ToyAlphabet);
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (gameManager.Alphabet == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        if (gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                }
                if (hit.collider.gameObject.tag == "Like Robots")
                {
                    gameManager.ToyChoice = gameManager.ToyRobot;
                    gameManager.ToyChoosing(gameManager.ToyRobot);
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (gameManager.Robots == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        if (gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                }
                if (hit.collider.gameObject.tag == "Like Sports")
                {
                    gameManager.ToyChoice = gameManager.ToySports;
                    gameManager.ToyChoosing(gameManager.ToySports);
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (gameManager.Sports == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        if (gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                }
                if (hit.collider.gameObject.tag == "Like Animals")
                {
                    gameManager.ToyChoice = gameManager.ToyAnimal;
                    gameManager.ToyChoosing(gameManager.ToyAnimal);
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (gameManager.Animals == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        if (gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                }

               
                if (hit.collider.gameObject.tag == "Like Music")
                {
                    gameManager.ToyChoice = gameManager.ToyMusic;
                    gameManager.ToyChoosing(gameManager.ToyMusic);
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;

                    if (gameManager.Music == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        if (gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                }
                if (hit.collider.gameObject.tag == "Like Space")
                {
                    gameManager.ToyChoice = gameManager.ToySpace;
                    gameManager.ToyChoosing(gameManager.ToySpace);
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (gameManager.Space == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        if (gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                }
                if (hit.collider.gameObject.tag == "Like Puzzles")
                {
                    gameManager.ToyChoice = gameManager.ToyPuzzle;
                    gameManager.ToyChoosing(gameManager.ToyPuzzle);
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    hit.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    if (gameManager.Puzzles == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        if (gameManager.toy3chosen == true)
                        {
                            gameManager.aPlaytimescore += 1;
                        }
                        else
                        {
                            gameManager.mPlaytimescore += 1;
                        }
                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }

                }

                

            }
            
        }
        //outside click

        if(gameManager.toy3chosen == true && gameManager.napover == false)
        {
            Playover();
            if (toyboxclosed == true)
            {
              //  Audio.me.PlaySound(toyclose);
                toyboxclosed = false;
            }
        }
        if (gameManager.toy6chosen == true && gameManager.napover == true)
        {
            Playover();
            Invoke("LoadScene", 1f);
            if(toyboxclosed == true)
            {
               // Audio.me.PlaySound(toyclose);
                toyboxclosed = false;
            }
            
        }

    }
    public void Playtime()
    {
        GameObject.FindGameObjectWithTag("Like Cars").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Robots").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Space").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Puzzles").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Animals").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Sports").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Music").GetComponent<SpriteRenderer>().enabled = true;

        GameObject.FindGameObjectWithTag("Like Cars").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Robots").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Space").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Puzzles").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Animals").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Sports").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.FindGameObjectWithTag("Like Music").GetComponent<BoxCollider2D>().enabled = true;


    }
    public void Playover()
    {
        GameObject.FindGameObjectWithTag("Like Cars").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Robots").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Space").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Puzzles").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Animals").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Sports").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Music").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Toybox").GetComponent<SpriteRenderer>().enabled = false;

        GameObject.FindGameObjectWithTag("Like Cars").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Robots").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Space").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Puzzles").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Animals").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Sports").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Like Music").GetComponent<BoxCollider2D>().enabled = false;
        gameManager.ToyChoice = 0;

       
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("mainroom");
    }
}
   






