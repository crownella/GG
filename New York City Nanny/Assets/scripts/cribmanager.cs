using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cribmanager : MonoBehaviour
{
    GameManager gameManager;

    public bool clicked = false;

    public AudioClip pageturn;

    public AudioClip fabric;

    bool BookChosen = false;
    // Use this for initialization
    void Start()
    {

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (gameManager.diaper1changed == false)
        {
            gameManager.Happinessmeter(-.30f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {

                if (hit.collider.gameObject.tag == "Like Cars")
                {
                    Audio.me.PlaySound(pageturn);
                    if (gameManager.Cars == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        gameManager.GoodBook = true;

                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                    BookChosen = true;
                }
                if (hit.collider.gameObject.tag == "Like Princesses")
                {
                    Audio.me.PlaySound(pageturn);
                    if (gameManager.Princesses == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        gameManager.GoodBook = true;

                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                    BookChosen = true;
                }               
                if (hit.collider.gameObject.tag == "Like Robots")
                {
                    Audio.me.PlaySound(pageturn);
                    if (gameManager.Robots == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        gameManager.GoodBook = true;

                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                    BookChosen = true;
                }
                if (hit.collider.gameObject.tag == "Like Space")
                {
                    Audio.me.PlaySound(pageturn);
                    if (gameManager.Space == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        gameManager.GoodBook = true;

                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                    BookChosen = true;
                }
                if (hit.collider.gameObject.tag == "Like Spanish")
                {
                    Audio.me.PlaySound(pageturn);
                    if (gameManager.Spanish == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        gameManager.GoodBook = true;

                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                    BookChosen = true;
                }
                if (hit.collider.gameObject.tag == "Like Alphabet")
                {
                    Audio.me.PlaySound(pageturn);
                    if (gameManager.Alphabet == true)
                    {
                        gameManager.Happinessmeter(.30f);
                        gameManager.GoodBook = true;

                    }
                    else
                    {
                        gameManager.Happinessmeter(-.30f);
                    }
                    BookChosen = true;
                }
                if (hit.collider.gameObject.tag == "Blanket" && BookChosen == true)
                {
                    Audio.me.PlaySound(fabric);


                    GameObject.FindGameObjectWithTag("Blanket").GetComponent<SpriteRenderer>().enabled = true;

                    GameObject.FindGameObjectWithTag("Eyes").GetComponent<SpriteRenderer>().enabled = true;


                    Invoke("LoadNextScene", 1f);

                    



                }
            }



            if (BookChosen == true) // removes books after picking one
            {
                GameObject.FindGameObjectWithTag("Like Cars").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Like Cars").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Like Robots").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Like Robots").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Like Space").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Like Space").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Like Spanish").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Like Spanish").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Blanket").GetComponent<BoxCollider2D>().enabled = true;


            }
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("mainroomdirty");
    }

}
