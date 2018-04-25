using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cleanmanager : MonoBehaviour
{





    public GameManager gameManager;

    GameObject[] Dirt;
    GameObject[] Muck;
    public GameObject Dirt1;
    public GameObject Dirt2;
    public GameObject Dirt3;
    public GameObject Dirt4;
    public GameObject Dirt5;
    public GameObject Dirt6;
    public GameObject Muck1;
    public GameObject Muck2;
    public GameObject Muck3;
    public GameObject Muck4;
    public GameObject Muck5;

    public bool Dirt1on = true;
    public bool Dirt2on = true;
    public bool Dirt3on = true;
    public bool Dirt4on = true;
    public bool Dirt5on = true;
    public bool Dirt6on = true;
    public bool Muck1on = true;
    public bool Muck2on = true;
    public bool Muck3on = true;
    public bool Muck4on = true;
    public bool Muck5on = true;

    public bool mop = false;
    public bool broom = false;


    public bool dirtgone = false;
    public bool muckgone = false;

    public AudioClip sweep;
    public AudioClip squish;

    // Use this for initialization
    void Start()
    {
         gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        /*
                Dirt = new GameObject[6];
                Muck = new GameObject[5];
                Dirt[1] = Dirt1;
                Dirt[2] = Dirt2;
                Dirt[3] = Dirt3;
                Dirt[4] = Dirt4;
                Dirt[5] = Dirt5;
                Dirt[0] = Dirt6;

                Muck[1] = Muck1;
                Muck[2] = Muck2;
                Muck[3] = Muck3;
                Muck[4] = Muck4;
                Muck[0] = Muck5;
                */
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {
                if (hit.collider.gameObject.tag == "Halfmop" && muckgone == false && broom == false)
                {
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    GameObject.FindGameObjectWithTag("Mop").GetComponent<SpriteRenderer>().enabled = true;
                    mop = true;

                }
                if (hit.collider.gameObject.tag == "Halfmop" && muckgone == true && broom == false)
                {
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    GameObject.FindGameObjectWithTag("Mop").GetComponent<SpriteRenderer>().enabled = false;
                    mop = false;
                   
                }
                if (hit.collider.gameObject.tag == "Halfbroom" && dirtgone == false && mop == false)
                {
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    GameObject.FindGameObjectWithTag("Broom").GetComponent<SpriteRenderer>().enabled = true;
                    broom = true;
                    
                }
                if (hit.collider.gameObject.tag == "Halfbroom" && dirtgone == true && mop == false)
                {
                    hit.collider.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    GameObject.FindGameObjectWithTag("Broom").GetComponent<SpriteRenderer>().enabled = false;
                    broom = false;
                }

                if (hit.collider.gameObject == Dirt1 && broom == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Dirt1on = false;
                    Audio.me.PlaySound(sweep);
                }
                if (hit.collider.gameObject == Dirt2 && broom == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Dirt2on = false;
                    Audio.me.PlaySound(sweep);

                }
                if (hit.collider.gameObject == Dirt3 && broom == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Dirt3on = false;
                    Audio.me.PlaySound(sweep);
                }
                if (hit.collider.gameObject == Dirt4 && broom == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Dirt4on = false;
                    Audio.me.PlaySound(sweep);
                }
                if (hit.collider.gameObject == Dirt5 && broom == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Dirt5on = false;
                    Audio.me.PlaySound(sweep);
                }
                if (hit.collider.gameObject == Dirt6 && broom == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Dirt6on = false;
                    Audio.me.PlaySound(sweep);
                }
                if (hit.collider.gameObject == Muck1 && mop == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Muck1on = false;
                    Audio.me.PlaySound(squish);
                }
                if (hit.collider.gameObject == Muck2 && mop == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Muck2on = false;
                    Audio.me.PlaySound(squish);
                }
                if (hit.collider.gameObject == Muck3 && mop == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Muck3on = false;
                    Audio.me.PlaySound(squish);
                }
                if (hit.collider.gameObject == Muck4 && mop == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Muck4on = false;
                    Audio.me.PlaySound(squish);
                }
                if (hit.collider.gameObject == Muck5 && mop == true)
                {
                    hit.collider.gameObject.SetActive(false);
                    Muck5on = false;
                    Audio.me.PlaySound(squish);
                }


            }
            //outside

            /*  int dirt = CheckDirt();
             if(dirt == 0)
             {
                 dirtgone = true;
             }
             int muck = CheckMuck();
             if(muck == 0)
             {
                 muckgone = true;
             }
             if(dirtgone == true && muckgone == true)
             {
                 Invoke("LoadScene", 1f);
             }
             */

        }
        if (Dirt1on == false && Dirt2on == false && Dirt3on == false && Dirt4on == false && Dirt5on == false && Dirt6on == false)
        {
            dirtgone = true;
        }
        if (Muck1on == false && Muck2on == false && Muck3on == false && Muck4on == false && Muck5on == false)
        {
            muckgone = true;
        }
        if(dirtgone == true && muckgone == true && broom == false)
        {
            Invoke("LoadScene", .5f);
          
        }







    } //end of update

    public int CheckDirt()
    {
        for (int i = 0; i < Dirt.Length; i++)
        {
            if (Dirt[i].activeSelf == true)
            {
                return i;
            }

        }
        return 0;
    }
    public int CheckMuck()
    {
        for (int i = 0; i < Muck.Length; i++)
        {
            if (Muck[i].activeSelf == true)
            {
                return i;
            }

        }
        return 0;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("sleepingbaby");
        gameManager.napover = true;
    }
}
