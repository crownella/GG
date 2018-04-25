using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    string SceneN; //used to know what scene is selected



    //audio clips

    public AudioClip Vibrate;
    public AudioClip bowlpickup;

    public ShakeScreen screenShake;

    public AudioClip sweep;

    public bool happyfood = false;

    public AudioClip music;

    public int FoodChoice = 0;
    public int FoodPhase = 0;
    public bool Fed = true;
    public bool FoodChosen = false;

    public int BreakfastChoice = 0;
    public int LunchChoice = 0;
    public int SnackChoice = 0;

    public bool diaper1changed = false;
    public bool diaper2changed = false;

    public bool lunch = false;

    public bool Ring = false;
    public bool ringing = false;

    public bool intro = false;

    public int mPlaytimescore = 0;
    public int aPlaytimescore = 0;

    public bool GoodBook = false;

    

    //scene managment

    public bool Debuff = false;

    public bool Endgame = false;
    public bool BookChosen = false;

    public bool diaper = false;


    //naptime
    
    public bool napover = false;




    //meters
    public float Happiness;
    

    //limtits
    bool happinesslimit;
   
    bool happinesslowerlimit;
   

    //meter manipluations 
    public float happinessloss;
  
    public float hmi; //happiness meter increase
    public float hmd; // happiness meter decrease 

    //gameend
  
    bool gamestart = false;
    public float score;
    public Text endgame;

    //toys in baby hand
    public int ToyCar = 1;
    public int ToyPrincess = 2;
    public int ToyPuzzle = 3;
    public int ToyRobot = 4;
    public int ToyAnimal = 5;
    public int ToySports = 6;
    public int ToySpace = 7;
    public int ToyMusic = 8;
    public int ToyAlphabet = 9;


    public int ToyChoice;

    public bool Playtime;

    public int ToyOne;
    public int ToyTwo;
    public int ToyThree;
    public int ToyFour;
    public int ToyFive;
    public int ToySix;

    public bool Toychosen;
    public bool toy1chosen;
    public bool toy3chosen;
    public bool toy2chosen;
    public bool toy4chosen;
    public bool toy5chosen;
    public bool toy6chosen;


    //childwants
    int Rando;
    int Rando2;
    int Rando3;
    int Rando4;
    int Rando5;
    int Rando6;
    public bool Cars = false;
    public bool Princesses = false;
    public bool Puzzles = false;
    public bool Robots = false;
    public bool Spanish = false;
    public bool Alphabet = false;
    public bool Music = false;
    public bool Animals = false;
    public bool Sports = false;
    public bool Space = false;


    Text Wants;

   


   

    // Use this for initialization
    void Start()
    {

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
        intializechildlikes();

    }

    // Update is called once per frame
    void Update()
    {
       

        //timer 




        //needs managment
        if (gamestart == true && endgame == false)
        {
            if (happinesslowerlimit == false)
            {
                Happiness -= happinessloss;

            }
           

        }
        if (Happiness >= 1.00)
        {
            happinesslimit = true;
        }
        else
        {
            happinesslimit = false;
        }
        if (Happiness <= .02f)
        {
            happinesslowerlimit = true;
        }
        else
        {
            happinesslowerlimit = false;
        }
        //---------------------------------------------------------
        

        //pointandclick
        if (Input.GetMouseButtonDown(0))
        {
            // Scene Management && point and click mechanic
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {
                
                if (hit.collider.gameObject.tag == "Crib" && napover == true)
                {
                    SceneManager.LoadScene("Bedroom");
                    
                    if(lunch == false)
                    {
                        Invoke("Cravings", 1f);
                    }
                    
                }
                if (hit.collider.gameObject.tag == "Phone")
                {
                    LoadDebuff();
                    Audio.me.PlaySound(music, .025f, 1f, true);
                }

            }

        }
        //this is outside point and click mechanic

        


        

    }

    public void LoadDebuff() //change from menu to debuff screen 
    {
        SceneManager.LoadScene("phonecall");


    }
    public void Happinessmeter(float number)
    {
        if (happinesslimit == false)
        {
            Happiness += number;
        }
    }

    public void intializechildlikes()
    {
        Rando = Random.Range(0, 10);
        Rando2 = Random.Range(0, 10);
        Rando3 = Random.Range(0, 10);
        Rando4 = Random.Range(0, 10);
        Rando5 = Random.Range(0, 10);
     

       

        if (Rando <= 5)
        {
            Cars = true;
        }
        if (Rando > 5)
        {
            Robots = true;
        }
        if (Rando2 > 5)
        {
            Princesses = true;
        }
        if (Rando2 <= 5)
        {
            Spanish = true;
        }
        if (Rando3 <= 5)
        {
            Sports = true;
        }
        if (Rando3 > 5)
        {
            Space = true;
        }
        if (Rando4 <= 5)
        {
            Alphabet = true;
        }
        if (Rando4 > 5)
        {
            Music = true;
        }
        if (Rando5 <= 5)
        {
            Puzzles= true;
        }
        if (Rando5 > 5)
        {
            Animals = true;
        }





    }
    public void PhoneRing()
    {
        GameObject.FindGameObjectWithTag("Screen").GetComponent<SpriteRenderer>().enabled = true;
        Ring = true;
        Invoke("Alerton", .1f);
        

    }
    public void Alerton()
    {
        GameObject.FindGameObjectWithTag("alert").GetComponent<SpriteRenderer>().enabled = true;
        Invoke("Alertoff", 1.2f);
        if(Ring == true)
        { Audio.me.PlaySound(Vibrate); }
       
    }
    public void Alertoff()
    {
        GameObject.FindGameObjectWithTag("alert").GetComponent<SpriteRenderer>().enabled = false;
        Invoke("Alerton", 1.2f);
        Ring = false;
       // Audio.me.StopSound(Vibrate);
    }

    public void Cravings()
    {
        
               
                GameObject.FindGameObjectWithTag("Chew").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Text1").GetComponent<SpriteRenderer>().enabled = true;
        Invoke("LoadScene", 1f);
                
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Mainroom");
    }
    public void ToyChoosing(int toychoice)
    {
        if(toy1chosen == false)
        {
            ToyOne = toychoice;
            toy1chosen = true;
        }
        else if (toy2chosen == false)
        {
            ToyTwo = toychoice;
            toy2chosen = true;
        }
        else if (toy3chosen == false)
        {
            ToyThree = toychoice;
            toy3chosen = true;
        }
        else if (toy4chosen == false)
        {
            ToyFour = toychoice;
            toy4chosen = true;
        }
        else if (toy5chosen == false)
        {
            ToyFive = toychoice;
            toy5chosen = true;
        }
        else if (toy6chosen == false)
        {
            ToySix = toychoice;
            toy6chosen = true;
        }
    }

}
