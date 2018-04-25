using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingAnimation : MonoBehaviour {
    GameManager gameManager;
    public Sprite chewing;
    public Sprite open;
    public GameObject ChewAnimation;
    

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		if(gameManager.Fed == false)
        {
            GetComponent<SpriteRenderer>().sprite = open;
            GameObject.FindGameObjectWithTag("Chew").GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = chewing;
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {
                if (hit.collider.gameObject.tag == "Mouth")
                {
                    Invoke("ChewAni", .25f);
                    
                }

            }
        }




    }
    public void ChewAni()
    {
        if(gameManager.Fed == true)
        {
            GameObject.FindGameObjectWithTag("Chew").GetComponent<SpriteRenderer>().enabled = true;
            Invoke("ChewAni2", .25f);
        }
    }
    public void ChewAni2()
    {
        if (gameManager.Fed == true)
        {
            GameObject.FindGameObjectWithTag("Chew").GetComponent<SpriteRenderer>().enabled = false;
            Invoke("ChewAni", .25f);
        }
    }
}
