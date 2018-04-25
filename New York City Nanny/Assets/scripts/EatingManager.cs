using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EatingManager : MonoBehaviour
{
    public GameManager gameManager;
    public int feedings = 0;

    bool readyToLoadNextScene = false;

    public AudioClip chew;
    public AudioClip foodmush;

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
                if (hit.collider.gameObject.tag == "Food" && gameManager.Fed == true)
                {


                    gameManager.FoodPhase += 1;
                    gameManager.Fed = false;
                    Audio.me.PlaySound(foodmush);

                    if (gameManager.FoodPhase == 5)
                    {
                        gameManager.FoodChosen = false;
                        gameManager.FoodChoice = 0;
                    }

                }



                if (hit.collider.gameObject.tag == "Mouth" && gameManager.FoodChosen == true)
                {
                    gameManager.Fed = true;
                    Audio.me.PlaySound(chew);

                }
            }
        }

        if (gameManager.FoodPhase == 4 && gameManager.Fed == true && readyToLoadNextScene == false)
        {




            readyToLoadNextScene = true;
            gameManager.FoodChosen = false;

            //SceneManager.LoadScene("Bedroom");

            Invoke("LoadNextScene", 1f);

        }

    }

    void LoadNextScene ()
    {
        if (gameManager.napover == true && gameManager.lunch == true)
        {
            SceneManager.LoadScene("Ending Scene");
        }
        else
        {
            SceneManager.LoadScene("Bedroom");
            gameManager.FoodPhase = 0;
            gameManager.FoodChoice = 0;
            if (gameManager.napover == true)
            {
                gameManager.lunch = true;
            }
        }
    }

}

