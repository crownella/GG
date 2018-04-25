using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainroomamanager : MonoBehaviour
{



    GameManager gameManager;

    public AudioClip fridgeclose;
    public AudioClip fridgeopen;
    public AudioClip platedown;
    public AudioClip babychew;
    public AudioClip doorclose;
    public AudioClip doorknob;

    public bool Fridge = false;
    public bool Door = false;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {

                if (hit.collider.gameObject.tag == "Fridge")
                {
                    gameManager.FoodChosen = false;
                    Fridge = true;
                    Audio.me.PlaySound(fridgeopen);
                }
                if (Fridge == true )
                {


                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("Choice 1");
                        gameManager.FoodChoice = 1;
                        gameManager.FoodChosen = true;
                        Fridge = false;
                        Audio.me.PlaySound(fridgeclose);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 2")
                    {
                        Debug.Log("Choice 2");
                        gameManager.FoodChoice = 2;
                        gameManager.FoodChosen = true;
                        Fridge = false;
                        Audio.me.PlaySound(fridgeclose);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 3")
                    {
                        Debug.Log("Choice 3");
                        gameManager.FoodChoice = 3;
                        gameManager.FoodChosen = true;
                        Fridge = false;
                        Audio.me.PlaySound(fridgeclose);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 4")
                    {
                        Debug.Log("Choice 4");
                        gameManager.FoodChoice = 4;
                        gameManager.FoodChosen = true;
                        Fridge = false;
                        Audio.me.PlaySound(fridgeclose);
                        gameManager.happyfood = true;
                    }

                    else if (hit.collider.gameObject.tag == "Choice X")
                    {
                        Debug.Log("Choice 5");
                        gameManager.FoodChoice = 5;
                        gameManager.FoodChosen = true;
                        Fridge = false;
                        Audio.me.PlaySound(fridgeclose);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 6")
                    {
                        Debug.Log("Choice 6");
                        gameManager.FoodChoice = 6;
                        gameManager.FoodChosen = true;
                        Fridge = false;
                        Audio.me.PlaySound(fridgeclose);
                        gameManager.happyfood = true;

                    }
                }
                else if (hit.collider.gameObject.tag == "Feeding" && gameManager.FoodChosen == true)
                {

                    
                    SceneManager.LoadScene(hit.collider.gameObject.tag);
                    Audio.me.PlaySound(platedown);


                }









                /* else //if u dont click on anything
                 {
                     if (Door == true)
                     {
                         Audio.me.PlaySound(doorclose);
                     }
                     if (Fridge == true)
                     {
                         Audio.me.PlaySound(fridgeclose);
                     }
                     Door = false;
                     Fridge = false;
                 }
                 */


            }

            
        }
        if (gameManager.napover == false)
        {
            gameManager.BreakfastChoice = gameManager.FoodChoice;

        }
        else if (gameManager.napover == true && gameManager.lunch == false)
        {
            gameManager.LunchChoice = gameManager.FoodChoice;
        }
        else if (gameManager.napover == true && gameManager.lunch == true)
        {
            gameManager.SnackChoice = gameManager.FoodChoice;

        }
            //outside point/click
            if (Fridge == false)//removes food from fridge when its closed
            {
                GameObject.FindGameObjectWithTag("Choice 1").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Choice 1").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Choice 2").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Choice 2").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Choice 3").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Choice 3").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Choice 4").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Choice 4").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Choice X").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Choice X").GetComponent<BoxCollider2D>().enabled = false;

                GameObject.FindGameObjectWithTag("Choice 6").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Choice 6").GetComponent<BoxCollider2D>().enabled = false;
                GameObject.FindGameObjectWithTag("Fridgeopen").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.FindGameObjectWithTag("Fridge").GetComponent<BoxCollider2D>().enabled = true;

            }
            if (Fridge == true) //makes food appear
            {
                GameObject.FindGameObjectWithTag("Choice 1").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Choice 1").GetComponent<BoxCollider2D>().enabled = true;

                GameObject.FindGameObjectWithTag("Choice 2").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Choice 2").GetComponent<BoxCollider2D>().enabled = true;

                GameObject.FindGameObjectWithTag("Choice 3").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Choice 3").GetComponent<BoxCollider2D>().enabled = true;

                GameObject.FindGameObjectWithTag("Choice 4").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Choice 4").GetComponent<BoxCollider2D>().enabled = true;

                GameObject.FindGameObjectWithTag("Choice X").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Choice X").GetComponent<BoxCollider2D>().enabled = true;

                GameObject.FindGameObjectWithTag("Choice 6").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Choice 6").GetComponent<BoxCollider2D>().enabled = true;
                GameObject.FindGameObjectWithTag("Fridgeopen").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Fridge").GetComponent<BoxCollider2D>().enabled = false;
            }

        
    }
}
    

