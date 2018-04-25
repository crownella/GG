using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaytimeAvatarChanger : MonoBehaviour {

    public Sprite Cars;
    public Sprite Princesses;
    public Sprite Puzzles;
    public Sprite Robots;
    public Sprite Skirt;
    public Sprite Alphabet;
    public Sprite Music;
    public Sprite Animals;
    public Sprite Sports;
    public Sprite Space;

    public GameManager gameManager;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if(gameManager.ToyChoice == 0)
        {
            GetComponent<SpriteRenderer>().sprite = Skirt;
        }

        if(gameManager.ToyCar == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Cars;
        }
        if (gameManager.ToyPrincess == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Princesses;
        }
        if (gameManager.ToyPuzzle == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Puzzles;
        }
        if (gameManager.ToyRobot == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Robots;
        }
        if (gameManager.ToyAlphabet == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Alphabet;
        }
        if (gameManager.ToyMusic == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Music;
        }
        if (gameManager.ToyAnimal == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Animals;
        }
        if (gameManager.ToySports == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Sports;
        }
        if (gameManager.ToySpace == gameManager.ToyChoice)
        {
            GetComponent<SpriteRenderer>().sprite = Space;
        }
    }
}
