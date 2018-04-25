using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour {
    GameManager gameManager;


    
    public static UIManager instance = null;


    public bool canvas1loaded = false;
    public bool canvas2loaded = false;


   


   

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this);
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
                
                if (hit.collider.gameObject.tag == "Park" && canvas2loaded == false)
                {
                    GameObject.FindGameObjectWithTag("canvas1").GetComponent<Image>().enabled = true;
                    GameObject.FindGameObjectWithTag("Screen").GetComponent<Image>().enabled = true;
                    GameObject.FindGameObjectWithTag("Likes(1)").GetComponent<Text>().enabled = true;
                    GameObject.FindGameObjectWithTag("Likes").GetComponent<Text>().enabled = true;
                    GameObject.FindGameObjectWithTag("Baby").GetComponent<Image>().enabled = true;
                    GameObject.FindGameObjectWithTag("Name").GetComponent<Text>().enabled = true;
                    if (gameManager.intro == true)
                    {
                        GameObject.FindGameObjectWithTag("door").GetComponent<BoxCollider2D>().enabled = false;
                    }

                        

                    canvas1loaded = true;
                    

                }
                if(hit.collider.gameObject.tag == "Respawn" && canvas2loaded == true)
                {
                    
                   
                    
                    GameObject.FindGameObjectWithTag("canvas2").GetComponent<Image>().enabled = false;
                    
                    GameObject.FindGameObjectWithTag("Chart").GetComponent<Image>().enabled = false;
                    GameObject.FindGameObjectWithTag("Screen").GetComponent<Image>().enabled = false;
                    canvas2loaded = false;
                    if (gameManager.intro == true)
                    {
                        SceneManager.LoadScene("Mainroom");
                        gameManager.intro = false;
                        
                    }
                    
                }
                if (hit.collider.gameObject.tag == "Respawn" && canvas1loaded == true) 
                {
                    
                    Changescreen();
                    canvas1loaded = false;
                }
                
            }
        }
       




    }
    public void Changescreen()
    {
        GameObject.FindGameObjectWithTag("canvas1").GetComponent<Image>().enabled = false;
        GameObject.FindGameObjectWithTag("Likes(1)").GetComponent<Text>().enabled = false;
        GameObject.FindGameObjectWithTag("Likes").GetComponent<Text>().enabled = false;
        GameObject.FindGameObjectWithTag("Baby").GetComponent<Image>().enabled = false;
        GameObject.FindGameObjectWithTag("Name").GetComponent<Text>().enabled = false;
        

        GameObject.FindGameObjectWithTag("canvas2").GetComponent<Image>().enabled = true;
        
        GameObject.FindGameObjectWithTag("Chart").GetComponent<Image>().enabled = true;

        canvas2loaded = true;
        
    }
}
