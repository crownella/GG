using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public bool Door = false;
    string SceneN; //used to know what scene is selected

    public Text endgame;
    


    //scene managment
    public bool Feeding = false;
    public bool Kitchen = false;
    public bool Playroom = false;
    public bool Crib = false;
    public bool Park = false;
    public bool Museum = false;
    public bool Diaper = false;
    public bool Cleaning = false;
    public bool Debuff = false;
    public bool Fridge = false;
    public bool Endgame = false;
    public bool BookChosen = false;

    public bool naptime = false;
    public float naptimer = 100;
    public float npd = .01f; //naptimerdecrease
    public bool napover = false;


    public int FoodChoice = 0;
    public bool FoodChosen = false;

    //meters
    public float Happiness = 70;
    public float Cleaness = 70;
    public float Hunger = 70;
    public float Sleep = 70;
    public float Hygenie = 70;
    public bool happinesslimit = false;
    public float happinessloss = .2f;
    public float score = 10;
    public float Hungerloss = .3f;

    public float timer = 100f;
    public float timerspeed = .001f;
    public bool gamestart = false;

    public float hmi = 5; //happiness meter increase
    public float hmd = -7; // happiness meter decrease 

    //childwants
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

    //boredom array
    public string[] bored;



    // Use this for initialization
    void Start()
    {
        
        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

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
        if (Cars == true)
        {
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
    void Update()
    {
        //timer
        if (gamestart == true)
        {
            timer -= timerspeed;
        }
        if(timer <= 0 && Endgame == false)
        {
            SceneManager.LoadScene("Ending Scene");
            Endgame = true;
            score = Happiness;

        }
        if(Endgame == true)
        {
            endgame = GameObject.FindGameObjectWithTag("Happiness").GetComponent<Text>();
            endgame.text = "Your score is " + score.ToString();
        }

        //happiness managment
        if (gamestart == true)
        {
            Happiness -= happinessloss;
        }
        if (Happiness >= 100)
        {
            happinesslimit = true;
        }
        else {
            happinesslimit = false;
        }

        //hunger
        if (gamestart == true)
        {
            Hunger -= Hungerloss;
        }

        

        //pointandclick
        if (Input.GetMouseButtonDown(0))
        {
            // Scene Management && point and click mechanic
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {
                if (gamestart == false)
                {
                    gamestart = true;
                }
                //scecne management clicking
                if (hit.collider.gameObject.tag == "bedroom") //go to bedroom
                {
                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Crib = false;
                    Diaper = false;
                    BookChosen = false;
                    
                }

                else if (hit.collider.gameObject.tag == "cleaning") //cleaning
                {
                    Cleaning = true;
                    Cleaness = Cleaness + 20;
                }

                else if (hit.collider.gameObject.tag == "Kitchen")
                {
                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Kitchen = true;
                    Feeding = false;
                    FoodChoice = 0;
                   
                }

                else if (hit.collider.gameObject.tag == "Playroom")
                {
                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Playroom = true;
                    
                }

                else if (hit.collider.gameObject.tag == "Mainroom")
                {
                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Kitchen = false;
                    Playroom = false;
                    Museum = false;
                    Park = false;
                    Cleaning = false;
                    Door = false;
                   

                }
                if (hit.collider.gameObject.tag == "Door")
                {
                    Debug.Log("True");
                    Door = true;
                }

                else if (hit.collider.gameObject.tag == "Crib")
                {
                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Crib = true;
                }

                else if (hit.collider.gameObject.tag == "Diaper")
                {

                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Diaper = true;
                }

                else if (hit.collider.gameObject.tag == "Feeding")
                {

                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Feeding = true;
                    Kitchen = false;
                    Fridge = false;
                }

               //clciking during certian scenes

                else if (Door == true && naptime == false)
                {

                    if (hit.collider.gameObject.tag == "Park")
                    {
                        SceneN = hit.collider.gameObject.tag;
                        Debug.Log(SceneN);
                        SceneManager.LoadScene(SceneN);
                        Door = false;
                        Park = true;
                    }

                    else if (hit.collider.gameObject.tag == "Museum")
                    {
                        SceneN = hit.collider.gameObject.tag;
                        Debug.Log(SceneN);
                        SceneManager.LoadScene(SceneN);
                        Door = false;
                    }
                }
                

                else if (Crib == true && naptime == false) //choices for crib scene
                {
                    //Debug.Log("Yay");
                    if (BookChosen == false)
                    {
                        
                        BookChosen = true;
                    }
                    if(BookChosen == true)
                    {
                        if (Rando2 < 9)
                        {
                            naptime = true;
                        }
                        else
                        {
                            Debug.Log(Childname + " won`t nap.");
                        }
                                 
                    }
                    
                }
                

                else if (Kitchen == true) //choices for kitchen scene
                {
                    //Debug.Log("Yay");
                    if (hit.collider.gameObject.tag == "Fridge" && FoodChosen == false)
                    {
                        Fridge = true;
                    }
                    else if(hit.collider.gameObject.tag == "Fridge" && FoodChosen == true)
                    {
                        FoodChosen = false;
                        Fridge = true;
                    }
                }
                
                if (Fridge == true & naptime == false) {
                    
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("Choice 1");
                        FoodChoice = 1;
                        FoodChosen = true;
                        Fridge = false;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 2")
                    {
                        Debug.Log("Choice 2");
                        FoodChoice = 2;
                        FoodChosen = true;
                        Fridge = false;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 3")
                    {
                        Debug.Log("Choice 3");
                        FoodChoice = 3;
                        FoodChosen = true;
                        Fridge = false;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 4")
                    {
                        Debug.Log("Choice 4");
                        FoodChoice = 4;
                        FoodChosen = true;
                        Fridge = false;
                    }

                    else if (hit.collider.gameObject.tag == "Choice X")
                    {
                        Debug.Log("Choice 5");
                        FoodChoice = 5;
                        FoodChosen = true;
                        Fridge = false;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 6")
                    {
                        Debug.Log("Choice 6");
                        FoodChoice = 6;
                        FoodChosen = true;
                        Fridge = false;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 7")
                    {
                        Debug.Log("Choice 7");
                        FoodChoice = 7;
                        FoodChosen = true;
                        Fridge = false;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 8")
                    {
                        Debug.Log("Choice 8");
                        FoodChoice = 8;
                        FoodChosen = true;
                        Fridge = false;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 9")
                    {
                        Debug.Log("Choice 9");
                        FoodChoice = 9;
                        FoodChosen = true;
                        Fridge = false;
                    }
                }
                
               
                else if (Feeding == true && naptime == false)
                {
                    if (hit.collider.gameObject.tag == "Choice X" && FoodChosen == true)
                    {
                        Debug.Log("feeding");
                        Happinessmeter(5);
                        Hunger += 20;
                        FoodChosen = false;
                        if (FoodChoice == 0)
                        {
                            Debug.Log("Food not chosen");
                        }
                        if (FoodChoice == 1)
                        {
                            Debug.Log("food 1");
                            Happinessmeter(5);
                        }
                        if (FoodChoice == 2)
                        {
                            Debug.Log("food 2");
                            Hunger += 30;
                        }
                        if (FoodChoice == 3)
                        {
                            Debug.Log("food 3");
                            Hunger += 20;
                        }
                        if (FoodChoice == 4)
                        {
                            Debug.Log("food 4");
                            Hunger += 15;
                        }
                        if (FoodChoice == 5)
                        {
                            Debug.Log("food 5");
                            Hunger += 20;
                        }
                        if (FoodChoice == 6)
                        {
                            Debug.Log("food 6");
                            Happinessmeter(5);
                        }
                        if (FoodChoice == 7)
                        {
                            Debug.Log("food 7");
                        }
                        if (FoodChoice == 8)
                        {
                            Debug.Log("food 8");
                        }
                        if (FoodChoice == 9)
                        {
                            Debug.Log("food 9");
                        }
                    }
                }
                if(Kitchen == false && Feeding == false)
                {
                    if (hit.collider.gameObject.tag == "Like Princesses")
                    {
                        if(Princesses == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like Cars")
                    {
                        if (Cars == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like Alphabet")
                    {
                        if (Alphabet == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like PP")
                    {
                        if (PlayingPretend == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like Sports")
                    {
                        if (Sports == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like Outdoors")
                    {
                        if (Outdoors == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like SH")
                    {
                        if (Superheros == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like Spanish")
                    {
                        if (Spanish == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like Music")
                    {
                        if (Music == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like Space")
                    {
                        if (Space == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Like CT")
                    {
                        if (Cartoons == true)
                        {
                            Happinessmeter(hmi);
                        }
                        else
                        {
                            Happinessmeter(hmd);
                        }
                    }
                } // makes choices affect happiness based on childs likes
                
                else if (Diaper == true && naptime == false)
                {
                    //affect hygenie meter
                    if (hit.collider.gameObject.tag == "Choice X")
                    {
                        Debug.Log("diaper changed");
                        Happinessmeter(5);
                        Hygenie += 40;
                    }
                }

            }
            else //if u dont click on anything
            {
                Door = false;
                Fridge = false;
            }

        }
        //this is outside point and click mechanic

        if (Debuff == true)
        {
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
            if (Princesses == false)
            {
                GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<Image>().enabled = false;
                GameObject.FindGameObjectWithTag("Dislike Princesses").GetComponent<Image>().enabled = true;
            }
            else if (Princesses == true)
            {
                GameObject.FindGameObjectWithTag("Dislike Princesses").GetComponent<Image>().enabled = false;
                GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<Image>().enabled = true;
            }
            if (Alphabet == false)
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

        //making choices appear/disappear
        if (Fridge == false && Kitchen == true)
        {
            GameObject.FindGameObjectWithTag("Choice 1").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Choice 1").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Choice 2").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Choice 2").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Choice 3").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Choice 3").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Choice 4").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Choice 4").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Choice X").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Choice X").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Choice 6").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Choice 6").GetComponent<BoxCollider2D>().enabled = false;
            
        }
        if(Fridge == true)
        {
            GameObject.FindGameObjectWithTag("Choice 1").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Choice 1").GetComponent<BoxCollider2D>().enabled = true;

            GameObject.FindGameObjectWithTag("Choice 2").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Choice 2").GetComponent<BoxCollider2D>().enabled = true;

            GameObject.FindGameObjectWithTag("Choice 3").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Choice 3").GetComponent<BoxCollider2D>().enabled = true;

            GameObject.FindGameObjectWithTag("Choice 4").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Choice 4").GetComponent<BoxCollider2D>().enabled = true;

            GameObject.FindGameObjectWithTag("Choice X").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Choice X").GetComponent<BoxCollider2D>().enabled = true;

            GameObject.FindGameObjectWithTag("Choice 6").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("Choice 6").GetComponent<BoxCollider2D>().enabled = true;
        }
        if(BookChosen == true && Crib == true)
        {
            GameObject.FindGameObjectWithTag("Like Cars").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Cars").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Princesses").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Like SH").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Like SH").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Like CT").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Like CT").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Like Space").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Space").GetComponent<BoxCollider2D>().enabled = false;

            GameObject.FindGameObjectWithTag("Like Spanish").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.FindGameObjectWithTag("Like Spanish").GetComponent<BoxCollider2D>().enabled = false;
        }
        if(naptime == true)
        {
            naptimer -= npd;
            if(Diaper == false && Crib == false && Feeding == false) {  //remove this when child avatar is added to these scenes
                GameObject.FindGameObjectWithTag("Child").GetComponent<SpriteRenderer>().enabled = false;
            }
            
            
        }
        if(naptimer < 0) // this isnt working and idk why
        {
            Debug.Log("napover");
            naptime = false;
            napover = true;
        }
        if(napover == true)
        {
            GameObject.FindGameObjectWithTag("Child").GetComponent<SpriteRenderer>().enabled = true;
        }
        if (Fridge == true && naptime == true)
        {
            Debug.Log(Childname + "is napping.");
            Fridge = false;
        }
        if (Crib == true && naptime == true)
        {
            Debug.Log(Childname + "is still napping.");

        }
        if(Feeding == true && naptime == true)
        {
            Debug.Log(Childname + "is still napping.");
        }
        if (Door == true && naptime == true)
        {
            Debug.Log(Childname + "is napping.");
            Door = false;
        }
        else if (Diaper == true && naptime == true)
        {
            Debug.Log(Childname + "is napping.");
            
        }
    }
    
    public void LoadDebuff()
    {
        SceneManager.LoadScene("Debuff");
        Debuff = true;
    }
    public void Happinessmeter(float number)
    {
        if (happinesslimit == false)
        {
            Happiness += number;
        }
    }
    


}
