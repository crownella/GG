using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCollider : MonoBehaviour {

    GameManager gameManager;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (gameManager != null)
        {
            if (gameManager.Door == true)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
