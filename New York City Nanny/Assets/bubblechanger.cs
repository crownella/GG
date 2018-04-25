using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bubblechanger : MonoBehaviour
{

    GameManager gameManager;
    public Sprite happy;
    public Sprite sad;
    public Sprite okay;
    public Sprite crying;
    public EndingManager endingmanager;
    int score;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        score = endingmanager.finalscore;
    }

    // Update is called once per frame
    void Update()
    {

        if (score <= 10)
        {
            gameObject.GetComponent<Image>().sprite = crying;
        }
    
        else if (score <= 30)
        {
             gameObject.GetComponent<Image>().sprite = sad;
        }
        
        else if (score <= 50)
        {
             gameObject.GetComponent<Image>().sprite = okay;
        
        }
        if (score == 70)
        {
             gameObject.GetComponent<Image>().sprite = happy;

        
        }

    }
}
