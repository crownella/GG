using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Startday : MonoBehaviour {
    GameManager gameManager;
   
   
   

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
       
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    
    
    public void AcceptJob()
    {
        
        GameObject.FindGameObjectWithTag("Finish").GetComponent<Image>().enabled = true;
        GameObject.FindGameObjectWithTag("Respawn").GetComponent<Text>().enabled = true;
        Invoke("ChangeScene", 1f);
    }
    public void ChangeScene()
    {

        SceneManager.LoadScene("intro");
    }
}
