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
    public float timerspeed = .002f;
    public bool gamestart = false;
    

    

    // Use this for initialization
    void Start()
    {
        
        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

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

                else if (Door == true)
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

                else if (Crib == true) //choices for crib scene
                {
                    //Debug.Log("Yay");
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("Choice 1");
                        Happinessmeter(5);
                        BookChosen = true;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 2")
                    {
                        Debug.Log("Choice 2");
                        Happinessmeter(5);
                        BookChosen = true;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 3")
                    {
                        Debug.Log("Choice 3");
                        Happinessmeter(5);
                        BookChosen = true;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 4")
                    {
                        Debug.Log("Choice 4");
                        Happinessmeter(5);
                        BookChosen = true;
                    }

                    else if (hit.collider.gameObject.tag == "Choice X")
                    {
                        Debug.Log("Choice 5");
                        Happinessmeter(5);
                        BookChosen = true;
                    }

                    else if (hit.collider.gameObject.tag == "Choice 6")
                    {
                        Debug.Log("Choice 6");
                        Happinessmeter(5);
                        BookChosen = true;
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
                if(Fridge == true) {
                    
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
                
               
                else if (Feeding == true)
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
                else if (Playroom == true)
                {
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("Choice 1");
                        Happinessmeter(5);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 2")
                    {
                        Debug.Log("Choice 2");
                        Happinessmeter(5);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 3")
                    {
                        Debug.Log("Choice 3");
                        Happinessmeter(5);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 4")
                    {
                        Debug.Log("Choice 4");
                        Happinessmeter(5);
                    }

                    else if (hit.collider.gameObject.tag == "Choice X")
                    {
                        Debug.Log("Choice 5");
                        Happinessmeter(5);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 6")
                    {
                        Debug.Log("Choice 6");
                        Happinessmeter(5);
                    }
                }
                else if (Park == true)
                {
                    
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("Choice 1");
                        Happinessmeter(5);
                    }

                    else if (hit.collider.gameObject.tag == "Choice 2")
                    {
                        Debug.Log("Choice 2");
                        Happinessmeter(5);
                    }

                    if (hit.collider.gameObject.tag == "Choice 3")
                    {
                        Debug.Log("Choice 3");
                        Happinessmeter(5);
                    }
                }
                else if (Museum == true)
                {
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("Choice 1");
                    }
                    if (hit.collider.gameObject.tag == "Choice 2")
                    {
                        Debug.Log("Choice 2");
                    }
                    if (hit.collider.gameObject.tag == "Choice 3")
                    {
                        Debug.Log("Choice 3");
                    }
                    if (hit.collider.gameObject.tag == "Choice 4")
                    {
                        Debug.Log("Choice 4");
                    }
                    if (hit.collider.gameObject.tag == "Choice X")
                    {
                        Debug.Log("Choice 5");
                    }
                    if (hit.collider.gameObject.tag == "Choice 6")
                    {
                        Debug.Log("Choice 6");
                    }
                }
                else if (Diaper == true)
                {
                    //affect hygenie meter
                    if (hit.collider.gameObject.tag == "Choice X")
                    {
                        Debug.Log("diaper changed");
                        Happinessmeter(5);
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
    }
    
    public void LoadDebuff()
    {
        SceneManager.LoadScene("Debuff");
        Debuff = true;
    }
    public void Happinessmeter(int number)
    {
        if (happinesslimit == false)
        {
            Happiness += number;
        }
    }


}
