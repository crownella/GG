using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiaperChange : MonoBehaviour {

    public GameManager gameManager;

    public Sprite Diaperchangeclosed;
    public Sprite Diaperchangeopen;
    public Sprite DiaperDirty;
    public Sprite Naked;
    public Sprite Skirt;
    public Sprite Diaper;

    public AudioClip fabric;
    public AudioClip velcro;
   
    public int diaperphase = 0;
    

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {
                if (hit.collider.gameObject.tag == "Diaper" && diaperphase == 2)
                {
                    if (gameManager.diaper == false)
                    {
                        gameManager.diaper = true;
                    }

                }
                if (hit.collider.gameObject.tag == "Player")
                {
                    if (diaperphase == 0)
                    {
                        GameObject.FindGameObjectWithTag("Finish").GetComponent<SpriteRenderer>().enabled = true;
                        Audio.me.PlaySound(fabric);
                        diaperphase += 1;
                        gameManager.diaper = false;
                    }
                    else if (gameManager.diaper == true )
                    {
                        diaperphase += 1;
                        gameManager.diaper = false;
                        Audio.me.PlaySound(fabric);

                    }
                    else if(diaperphase == 1)
                    {
                        diaperphase += 1;
                        Audio.me.PlaySound(fabric);
                        gameManager.diaper = false;
                    }
                    else if(diaperphase == 3)
                    {
                        diaperphase += 1;
                        Audio.me.PlaySound(velcro);
                        gameManager.diaper = false;
                    }
                }
                if(hit.collider.gameObject.tag == "Finish" && diaperphase == 4) //puts skirt on
                {
                    diaperphase += 1;
                    GameObject.FindGameObjectWithTag("Finish").GetComponent<SpriteRenderer>().enabled = false;
                    Audio.me.PlaySound(fabric);
                }
            }
        }
            //outside pointclick

         if(diaperphase == 0)
        {
            GetComponent<SpriteRenderer>().sprite = Skirt;
        }
         if(diaperphase == 1)
        {
            GetComponent<SpriteRenderer>().sprite = DiaperDirty;
        }
         if(diaperphase == 2)
        {
            GetComponent<SpriteRenderer>().sprite = Naked;
            GameObject.FindGameObjectWithTag("Pixel").GetComponent<SpriteRenderer>().enabled = true;
        }
        if (diaperphase == 3)
        {
            GetComponent<SpriteRenderer>().sprite = Diaperchangeopen;
            GameObject.FindGameObjectWithTag("Pixel").GetComponent<SpriteRenderer>().enabled = false;
        }
        if(diaperphase == 4)
        {
            GetComponent<SpriteRenderer>().sprite = Diaperchangeclosed;
        }
        if(diaperphase == 5)
        {
            GetComponent<SpriteRenderer>().sprite = Skirt;
            SceneManager.LoadScene("bedroom");
            if(gameManager.napover == false)
            {
                gameManager.diaper1changed = true;
            }
            else {
                gameManager.diaper2changed = true;
            }
           

        }
        if(gameManager.diaper == true)
        {
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<SpriteRenderer>().enabled = false;
        }
    }


        
    
}
