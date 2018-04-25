using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intromanager : MonoBehaviour {

    public AudioClip knock;
    public AudioClip dooropen;

    GameManager gameManager;

    public bool knocked = false;

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
                if(hit.collider.gameObject.tag == "door" && knocked == false)
                {
                    
                    Audio.me.PlaySound(knock);
                    Invoke("OpenDoor", 2f);
                    knocked = true;
                    
                    gameManager.intro = true;
                }
            }
        }

    }
    public void OpenDoor()
    {
        GameObject.FindGameObjectWithTag("door").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("dooropen").GetComponent<SpriteRenderer>().enabled = true;
        Audio.me.PlaySound(dooropen);
        Invoke("Speak", .5f);
        

    }
    public void Speak()
    {
        GameObject.FindGameObjectWithTag("Text1").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Mouth").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindGameObjectWithTag("Phone").GetComponent<Image>().enabled = true;
        

        
    }
}
