using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechanger : MonoBehaviour
{
    public Sprite fork;
    public Sprite donut;
    public Sprite cupcake;
    public Sprite oatmeal;
    public Sprite apple;
    public Sprite banana;
    public Sprite chicken;
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
            if (gameManager.FoodChoice == 0 || gameManager.Fed == true)
            {

                GetComponent<SpriteRenderer>().sprite = fork;

            }
            else if (gameManager.FoodChoice == 1)
            {

                GetComponent<SpriteRenderer>().sprite = chicken;

            }
            else if (gameManager.FoodChoice == 2)
            {

                GetComponent<SpriteRenderer>().sprite = apple;

            }
            else if (gameManager.FoodChoice == 4)
            {

                GetComponent<SpriteRenderer>().sprite = cupcake;

            }
            else if (gameManager.FoodChoice == 5)
            {

                GetComponent<SpriteRenderer>().sprite = oatmeal;

            }
            else if (gameManager.FoodChoice == 3)
            {

                GetComponent<SpriteRenderer>().sprite = banana;

            }
            else if (gameManager.FoodChoice == 6)
            {

                GetComponent<SpriteRenderer>().sprite = donut;

            }



        }
    }
}
