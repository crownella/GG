using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthChange : MonoBehaviour {
    GameManager gameManager;
    public Sprite happy;
    public Sprite sad;
    public Sprite okay;
    public Sprite crying;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        
		if(gameManager.Happiness > .75)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = happy;
        }
        else if(gameManager.Happiness > .50)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = okay;
        }
        else if (gameManager.Happiness > .30)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sad;
        }
        else 
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = crying;
        }
    }
}
