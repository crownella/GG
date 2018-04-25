using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpriteChanger : MonoBehaviour
{

    public Sprite donut;
    public Sprite donut1b;
    public Sprite donut2b;
    public Sprite donut3b;

    public Sprite cupcake;
    public Sprite cupcake1b;
    public Sprite cupcake2b;
    public Sprite cupcake3b;

    public Sprite oatmeal;
    public Sprite oatmeal1b;
    public Sprite oatmeal2b;
    public Sprite oatmeal3b;

    public Sprite apple;
    public Sprite apple1b;
    public Sprite apple2b;
    public Sprite apple3b;

    public Sprite banana;
    public Sprite banana1b;
    public Sprite banana2b;
    public Sprite banana3b;

    public Sprite chicken;
    public Sprite chicken1b;
    public Sprite chicken2b;
    public Sprite chicken3b;

    public Sprite blank;

    public AudioClip test;

    public GameManager gameManager;


    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
        // Update is called once per frame
        void Update()
        {
            if (gameManager != null)
            {
                if (gameManager.FoodChoice == 0 || gameManager.FoodPhase == 4)
                {

                    GetComponent<SpriteRenderer>().sprite = blank;

                }
                else if (gameManager.FoodChoice == 1)
                {
                    if (gameManager.FoodPhase == 0)
                    {
                        GetComponent<SpriteRenderer>().sprite = chicken;
                        //playsound(
                    }
                    else if (gameManager.FoodPhase == 1)
                    {
                        GetComponent<SpriteRenderer>().sprite = chicken1b;
                    }
                    else if (gameManager.FoodPhase == 2)
                    {
                        GetComponent<SpriteRenderer>().sprite = chicken2b;
                    }
                    else if (gameManager.FoodPhase == 3)
                    {
                        GetComponent<SpriteRenderer>().sprite = chicken3b;
                    }




                }
                else if (gameManager.FoodChoice == 2)
                {
                    if (gameManager.FoodPhase == 0)
                    {
                        GetComponent<SpriteRenderer>().sprite = apple;
                    }
                    else if (gameManager.FoodPhase == 1)
                    {
                        GetComponent<SpriteRenderer>().sprite = apple1b;
                    }
                    else if (gameManager.FoodPhase == 2)
                    {
                        GetComponent<SpriteRenderer>().sprite = apple2b;
                    }
                    else if (gameManager.FoodPhase == 3)
                    {
                        GetComponent<SpriteRenderer>().sprite = apple3b;
                    }

                }
                else if (gameManager.FoodChoice == 4)
                {


                    if (gameManager.FoodPhase == 0)
                    {
                        GetComponent<SpriteRenderer>().sprite = cupcake;
                    }
                    else if (gameManager.FoodPhase == 1)
                    {
                        GetComponent<SpriteRenderer>().sprite = cupcake1b;
                    }
                    else if (gameManager.FoodPhase == 2)
                    {
                        GetComponent<SpriteRenderer>().sprite = cupcake2b;
                    }
                    else if (gameManager.FoodPhase == 3)
                    {
                        GetComponent<SpriteRenderer>().sprite = cupcake3b;
                    }

                }
                else if (gameManager.FoodChoice == 5)
                {


                    if (gameManager.FoodPhase == 0)
                    {
                        GetComponent<SpriteRenderer>().sprite = oatmeal;
                    }
                    else if (gameManager.FoodPhase == 1)
                    {
                        GetComponent<SpriteRenderer>().sprite = oatmeal1b;
                    }
                    else if (gameManager.FoodPhase == 2)
                    {
                        GetComponent<SpriteRenderer>().sprite = oatmeal2b;
                    }
                    else if (gameManager.FoodPhase == 3)
                    {
                        GetComponent<SpriteRenderer>().sprite = oatmeal3b;
                    }

                }
                else if (gameManager.FoodChoice == 3)
                {


                    if (gameManager.FoodPhase == 0)
                    {
                        GetComponent<SpriteRenderer>().sprite = banana;
                    }
                    else if (gameManager.FoodPhase == 1)
                    {
                        GetComponent<SpriteRenderer>().sprite = banana1b;
                    }
                    else if (gameManager.FoodPhase == 2)
                    {
                        GetComponent<SpriteRenderer>().sprite = banana2b;
                    }
                    else if (gameManager.FoodPhase == 3)
                    {
                        GetComponent<SpriteRenderer>().sprite = banana3b;
                    }

                }
                else if (gameManager.FoodChoice == 6)
                {


                    if (gameManager.FoodPhase == 0)
                    {
                        GetComponent<SpriteRenderer>().sprite = donut;
                    }
                    else if (gameManager.FoodPhase == 1)
                    {
                        GetComponent<SpriteRenderer>().sprite = donut1b;
                    }
                    else if (gameManager.FoodPhase == 2)
                    {
                        GetComponent<SpriteRenderer>().sprite = donut2b;
                    }
                    else if (gameManager.FoodPhase == 3)
                    {
                        GetComponent<SpriteRenderer>().sprite = donut3b;
                    }
                }



            }
        }
    }
