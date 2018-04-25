using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class debuffstuff : MonoBehaviour {

    GameManager gameManager;
    Text Wants;

    string[] Childwants;
    public string Childname = "Bobby";


    // Use this for initialization
    void Start()
    {
        Wants = GameObject.FindGameObjectWithTag("Likes(1)").GetComponent<Text>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Childwants = new string[24];
        if (gameManager.Cars == true)
        {
            Childwants[1] = "Cars ";
           
        }
        else
        {
            Childwants[1] = "";
            
        }
        if (gameManager.Robots == true)
        {
            Childwants[2] = "Robots ";
           
        }
        else
        {
            Childwants[2] = "";
            
        }
        if (gameManager.Princesses == true)
        {
            Childwants[3] = "Princesses ";
           
        }
        else
        {
            Childwants[3] = "";
           
        }
        if (gameManager.Sports == true)
        {
            Childwants[4] = "Sports ";
            
        }
        else
        {
            Childwants[4] = "";
            
        }
        if (gameManager.Animals == true)
        {
            Childwants[5] = "Animals ";
           
        }
        else
        {
            Childwants[5] = "";
            
        }
        if (gameManager.Spanish == true)
        {
            Childwants[6] = "Spanish ";
           
        }
        else
        {
            Childwants[6] = "";
            
        }
        if (gameManager.Puzzles == true)
        {
            Childwants[7] = "Puzzles ";
            
        }
        else
        {
            Childwants[7] = "";
           
        }
        
       
        if (gameManager.Music == true)
        {
            Childwants[9] = "Music ";
            
        }
        else
        {
            Childwants[9] = "";
            
        }
        if (gameManager.Alphabet == true)
        {
            Childwants[10] = "Alphabet ";
           
        }
        else
        {
            Childwants[10] = "";
            
        }
        if (gameManager.Space == true)
        {
            Childwants[11] = "Space ";
           
        }
        else
        {
            Childwants[11] = "";
          
        }
        Wants.text = Childwants[1] + Childwants[2] + Childwants[3] + Childwants[4] + Childwants[5] + Childwants[6] + Childwants[7] + Childwants[8] + Childwants[9] + Childwants[10] + Childwants[11];
    }

    // Update is called once per frame
    void Update()
    {
        
        




            
        
    }
    public void AcceptJob()
    {
        GameObject.FindGameObjectWithTag("Finish").GetComponent<Image>().enabled = false;
        GameObject.FindGameObjectWithTag("Respawn").GetComponent<Text>().enabled = false;
        Invoke("ChangeScene", 2f);
    }
    public void ChangeScene()
    {

        SceneManager.LoadScene("Mainroom");
    }
}
