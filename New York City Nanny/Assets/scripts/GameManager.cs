using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool Door = false;
    string SceneN; //used to know what scene is selected

    //scene managment
    public bool Feeding = false;
    public bool Kitchen = false;
    public bool Playroom = false;
    public bool Crib = false;
    public bool Park = false;
    public bool Museum = false;
    public bool Diaper = false;
    public bool Cleaning = false;
    public int FoodChoice = 0;
    public bool FoodChosen = false;

    //meters
    public int Happiness = 70;
    public int Cleaness = 70;
    public int Hunger = 70;
    public int Sleep = 70;
    public int Hygenie = 70;



    // Use this for initialization
    void Start()
    {

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            // Scene Management
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {


                if (hit.collider.gameObject.tag == "bedroom")
                {
                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Crib = false;
                    Diaper = false;
                }

                if (hit.collider.gameObject.tag == "cleaning")
                {
                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Cleaning = true;
                }

                else if (hit.collider.gameObject.tag == "Kitchen")
                {
                    SceneN = hit.collider.gameObject.tag;
                    Debug.Log(SceneN);
                    SceneManager.LoadScene(SceneN);
                    Kitchen = true;
                    Feeding = false;
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

                }


                else if (hit.collider.gameObject.tag == "Door")
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
                }

                if (Door == true)
                {

                    if (hit.collider.gameObject.tag == "Park")
                    {
                        SceneN = hit.collider.gameObject.tag;
                        Debug.Log(SceneN);
                        SceneManager.LoadScene(SceneN);
                        Door = false;
                    }

                    else if (hit.collider.gameObject.tag == "Museum")
                    {
                        SceneN = hit.collider.gameObject.tag;
                        Debug.Log(SceneN);
                        SceneManager.LoadScene(SceneN);
                        Door = false;
                    }
                }

                if (Crib == true) //choices for crib scene
                {
                    //Debug.Log("Yay");
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

                    if (hit.collider.gameObject.tag == "Choice 7")
                    {
                        Debug.Log("Choice 7");
                    }

                    if (hit.collider.gameObject.tag == "Choice 6")
                    {
                        Debug.Log("Choice 6");
                    }
                }

                if (Kitchen == true) //choices for kitchen scene
                {
                    //Debug.Log("Yay");
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("Choice 1");
                        FoodChoice = 1;
                        FoodChosen = true;
                    }

                    if (hit.collider.gameObject.tag == "Choice 2")
                    {
                        Debug.Log("Choice 2");
                        FoodChoice = 2;
                        FoodChosen = true;
                    }

                    if (hit.collider.gameObject.tag == "Choice 3")
                    {
                        Debug.Log("Choice 3");
                        FoodChoice = 3;
                        FoodChosen = true;
                    }

                    if (hit.collider.gameObject.tag == "Choice 4")
                    {
                        Debug.Log("Choice 4");
                        FoodChoice = 4;
                        FoodChosen = true;
                    }

                    if (hit.collider.gameObject.tag == "Choice X")
                    {
                        Debug.Log("Choice 5");
                        FoodChoice = 5;
                        FoodChosen = true;
                    }

                    if (hit.collider.gameObject.tag == "Choice 6")
                    {
                        Debug.Log("Choice 6");
                        FoodChoice = 6;
                        FoodChosen = true;
                    }

                    if (hit.collider.gameObject.tag == "Choice 7")
                    {
                        Debug.Log("Choice 7");
                        FoodChoice = 7;
                        FoodChosen = true;
                    }

                    if (hit.collider.gameObject.tag == "Choice 8")
                    {
                        Debug.Log("Choice 8");
                        FoodChoice = 8;
                        FoodChosen = true;
                    }

                    if (hit.collider.gameObject.tag == "Choice 9")
                    {
                        Debug.Log("Choice 9");
                        FoodChoice = 9;
                        FoodChosen = true;
                    }
                }
                if (Feeding == true)
                {
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("feeding");
                        if (FoodChoice == 1)
                        {
                            Debug.Log("food 1");
                        }
                        if (FoodChoice == 2)
                        {
                            Debug.Log("food 2");
                        }
                        if (FoodChoice == 3)
                        {
                            Debug.Log("food 3");
                        }
                        if (FoodChoice == 4)
                        {
                            Debug.Log("food 4");
                        }
                        if (FoodChoice == 5)
                        {
                            Debug.Log("food 5");
                        }
                        if (FoodChoice == 6)
                        {
                            Debug.Log("food 6");
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
                if (Playroom == true)
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
                if (Park == true)
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
                }
                if (Museum == true)
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
                if (Diaper == true)
                {
                    //affect hygenie meter
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("diaper changed");
                    }
                }
                if (Cleaning == true)
                {
                    //affect cleaning  meter
                    if (hit.collider.gameObject.tag == "Choice 1")
                    {
                        Debug.Log("Clean");
                    }
                }

            }
            else
            {
                Door = false;
            }

        }
    }
    public void Startgame()
    {
        SceneManager.LoadScene("Mainroom");
    }



}
