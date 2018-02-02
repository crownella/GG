using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

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
                    Debug.Log("bedroom");
                    SceneManager.LoadScene("Bedroom");
                }

                if (hit.collider.gameObject.tag == "Kitchen")
                {
                    Debug.Log("Kitchen");
                    SceneManager.LoadScene("Kitchen");
                }

                if (hit.collider.gameObject.tag == "Playroom")
                {
                    Debug.Log("Playroom");
                    SceneManager.LoadScene("Playroom");
                }
            }

        }
        }
    }
