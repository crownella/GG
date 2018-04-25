using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactions : MonoBehaviour {

    GameManager gameManager;
    public Sprite happy;
    public Sprite sad;
    public Sprite okay;
    public Sprite mad;


    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    
}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Happymom()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = happy;
    }
    public void Sadmom()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sad;
    }
    public void Madmom()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = mad;
    }
    public void Okaymom()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = okay;
    }
}
