using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startday : MonoBehaviour {
    GameManager gameManager;
   

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void Startgame()
    {
        SceneManager.LoadScene("Mainroom");
        gameManager.Debuff = false;
    }
}
