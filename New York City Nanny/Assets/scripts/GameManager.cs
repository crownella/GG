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

                    if (hit.collider.gameObject.tag == "Choice 7")
                    {
                        Debug.Log("Choice 7");
                    }

                    if (hit.collider.gameObject.tag == "Choice 8")
                    {
                        Debug.Log("Choice 8");
                    }

                    if (hit.collider.gameObject.tag == "Choice 9")
                    {
                        Debug.Log("Choice 9");
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
