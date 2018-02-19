using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class childwants : MonoBehaviour {

    //child wants
    public int Rando;
    public int Rando2;
    public int Rando3;
    public int Rando4;
    public bool Cars = false;
    public bool Princesses = false;
    public bool Cartoons = false;
    public bool Superheros = false;
    public bool PlayingPretend = false;
    public bool Spanish = false;
    public bool Alphabet = false;
    public bool Music = false;
    public bool Outdoors = false;
    public bool Sports = false;
    public bool Space = false;
    private string[] Childwants;
    public string Childname = "Bobby";

    public Text Wants;

    // Use this for initialization
    void Start () {
        //DontDestroyOnLoad(gameObject);

        Rando = Random.Range(0, 10);
        Rando2 = Random.Range(0, 10);
        Rando3 = Random.Range(0, 10);
        Rando4 = Random.Range(0, 10);

        if (Rando < 3)
        { Cars = true; }
        if (Rando < 7)
        { PlayingPretend = true; }
        if (Rando > 6)
        { Princesses = true; }
        if (Rando2 > 4)
        { Spanish = true; }
        if (Rando2 < 6)
        { Sports = true; }
        if (Rando2 < 7)
        { Space = true; }
        if (Rando3 < 4)
        { Alphabet = true; }
        if (Rando3 > 6)
        { Music = true; }
        if (Rando3 < 7)
        { Superheros = true; }
        if (Rando4 < 3)
        { Outdoors = true; }
        if (Rando4 > 8)
        { Cartoons = true; }


        Childwants = new string[24];
        if (Cars == true){
            Childwants[1] = "cars,";
            Childwants[12] = "";
        }
        else
        {
            Childwants[1] = "";
            Childwants[12] = "cars,";
        }
        if (PlayingPretend == true)
        {
            Childwants[2] = "playing pretend,";
            Childwants[13] = "";
        }
        else
        {
            Childwants[2] = "";
            Childwants[13] = "playing pretend,";
        }
        if (Princesses == true)
        {
            Childwants[3] = "princesses,";
            Childwants[14] = "";
        }
        else
        {
            Childwants[3] = "";
            Childwants[14] = "princesses,";
        }
        if (Sports == true)
        {
            Childwants[4] = "sports,";
            Childwants[15] = "";
        }
        else
        {
            Childwants[4] = "";
            Childwants[15] = "sports,";
        }
        if (Outdoors == true)
        {
            Childwants[5] = "the outdoors,";
            Childwants[16] = "";
        }
        else
        {
            Childwants[5] = "";
            Childwants[16] = "the outdoors,";
        }
        if (Spanish == true)
        {
            Childwants[6] = "learning spanish,";
            Childwants[17] = "";
        }
        else
        {
            Childwants[6] = "";
            Childwants[17] = "learning spanish,";
        }
        if (Cartoons == true)
        {
            Childwants[7] = "cartoons,";
            Childwants[18] = "";
        }
        else
        {
            Childwants[7] = "";
            Childwants[18] = "cartoons,";
        }
        if (Superheros == true)
        {
            Childwants[8] = "superheros,";
            Childwants[19] = "";
        }
        else
        {
            Childwants[8] = "";
            Childwants[19] = "superheros,";
        }
        if (Music == true)
        {
            Childwants[9] = "music,";
            Childwants[20] = "";
        }
        else
        {
            Childwants[9] = "";
            Childwants[20] = "music,";
        }
        if (Alphabet == true)
        {
            Childwants[10] = "alphabet,";
            Childwants[21] = "";
        }
        else
        {
            Childwants[10] = "";
            Childwants[21] = "alphabet,";
        }
        if (Space == true)
        {
            Childwants[11] = "space,";
            Childwants[22] = "";
        }
        else
        {
            Childwants[11] = "";
            Childwants[22] = "space,";
        }

        

    }

    // Update is called once per frame
    void Update () {
        Wants = GameObject.FindGameObjectWithTag("Text1").GetComponent<Text>();
        Wants.text = (Childname) + " likes " + Childwants[1] + Childwants[2] + Childwants[3] + Childwants[4]
            + Childwants[5] + Childwants[6] + Childwants[7] + Childwants[8] + Childwants[9] + Childwants[10] 
            + Childwants[11] + Childwants[12] + "and sweets, of course. " + Childname + " doesn't like " + 
            Childwants[12] + Childwants[13] + Childwants[14] + Childwants[15] + Childwants[16] + Childwants[17]
            + Childwants[18] + Childwants[19] + Childwants[20] + Childwants[21] + Childwants[22] + " or anything green." +
            " Remember to change her diaper, feed her, and keep the house clean.";



        if (Cars == false)
        {
            GameObject.FindGameObjectWithTag("Like Cars").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike Cars").GetComponent<Image>().enabled = true;
        }
        else if (Cars == true)
        {
            GameObject.FindGameObjectWithTag("Dislike Cars").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Cars").GetComponent<Image>().enabled = true;
        }
        if ( Princesses == false)
        {
            GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike Princesses").GetComponent<Image>().enabled = true;
        }
        else if (Princesses == true)
        {
            GameObject.FindGameObjectWithTag("Dislike Princesses").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<Image>().enabled = true;
        }
        if(Alphabet == false)
        {
            GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike Alphabet").GetComponent<Image>().enabled = true;
        }
        else if (Alphabet == true)
        {
            GameObject.FindGameObjectWithTag("Dislike Alphabet").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Alphabet").GetComponent<Image>().enabled = true;
        }
        if (PlayingPretend == false)
        {
            GameObject.FindGameObjectWithTag("Like PP").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike PP").GetComponent<Image>().enabled = true;
        }
        else if (PlayingPretend == true)
        {
            GameObject.FindGameObjectWithTag("Dislike PP").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like PP").GetComponent<Image>().enabled = true;
        }
        if (Sports == false)
        {
            GameObject.FindGameObjectWithTag("Like Sports").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike Sports").GetComponent<Image>().enabled = true;
        }
        else if (Sports == true)
        {
            GameObject.FindGameObjectWithTag("Dislike Sports").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Sports").GetComponent<Image>().enabled = true;
        }
        if (Outdoors == false)
        {
            GameObject.FindGameObjectWithTag("Like Outdoors").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike Outdoors").GetComponent<Image>().enabled = true;
        }
        else if (Outdoors == true)
        {
            GameObject.FindGameObjectWithTag("Dislike Outdoors").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Outdoors").GetComponent<Image>().enabled = true;
        }
        if (Superheros == false)
        {
            GameObject.FindGameObjectWithTag("Like SH").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike SH").GetComponent<Image>().enabled = true;
        }
        else if (Superheros == true)
        {
            GameObject.FindGameObjectWithTag("Dislike SH").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like SH").GetComponent<Image>().enabled = true;
        }
        if (Spanish == false)
        {
            GameObject.FindGameObjectWithTag("Like Spanish").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike Spanish").GetComponent<Image>().enabled = true;
        }
        else if (Spanish == true)
        {
            GameObject.FindGameObjectWithTag("Dislike Spanish").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Spanish").GetComponent<Image>().enabled = true;
        }
        if (Music == false)
        {
            GameObject.FindGameObjectWithTag("Like Music").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike Music").GetComponent<Image>().enabled = true;
        }
        else if (Music == true)
        {
            GameObject.FindGameObjectWithTag("Dislike Music").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Music").GetComponent<Image>().enabled = true;
        }
        if (Space == false)
        {
            GameObject.FindGameObjectWithTag("Like Space").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike Space").GetComponent<Image>().enabled = true;
        }
        else if (Space == true)
        {
            GameObject.FindGameObjectWithTag("Dislike Space").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Space").GetComponent<Image>().enabled = true;
        }
        if (Cartoons == false)
        {
            GameObject.FindGameObjectWithTag("Like CT").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Dislike CT").GetComponent<Image>().enabled = true;
        }
        else if (Cartoons == true)
        {
            GameObject.FindGameObjectWithTag("Dislike CT").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("Like CT").GetComponent<Image>().enabled = true;
        }
    }
}
