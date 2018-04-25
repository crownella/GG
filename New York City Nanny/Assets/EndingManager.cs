using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour
{

    GameManager gameManager;
    public GameObject BreakfastText;
    public GameObject MorningPlayText;
    public GameObject FinalText;
    public GameObject BookText;
    public GameObject LunchText;
    public GameObject AfternoonPlayText;
    public GameObject DiaperText;
    public GameObject SnackText;

    Text Breakfast;
    Text MorningPlay;
    Text Final;
    Text Book;
    Text Lunch;
    Text AfternoonPlay;
    Text Diaper;
    Text Snack;

    int breakfastscore;
    int morningplayscore;
    public int finalscore;
    int bookscore;
    int lunchscore;
    int afternoonplayscore;
    int diaperscore;
    int snackscore;

    public reactions reactions;

    public AudioClip momhappy;
    public AudioClip momokay;
    public AudioClip momsad;
    public AudioClip mommad;

    public AudioClip yay;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        Breakfast = BreakfastText.GetComponent<Text>();
        MorningPlay = MorningPlayText.GetComponent<Text>();

        Book = BookText.GetComponent<Text>();
        Lunch = LunchText.GetComponent<Text>();
        AfternoonPlay = AfternoonPlayText.GetComponent<Text>();
        Diaper = DiaperText.GetComponent<Text>();
        Snack = SnackText.GetComponent<Text>();
        Final = FinalText.GetComponent<Text>();


        //score calculation-------------------------------------------------------------------------------------------------------------------------------------------------
        // food choices in order: Chicken, Apple, Banana, Cupcake, Oatmeal, Donut

        if (gameManager.BreakfastChoice != 0)
        {
            if (gameManager.BreakfastChoice == 1)
            {
                breakfastscore = 2;
            }
            if (gameManager.BreakfastChoice == 2)
            {
                breakfastscore = 6;
            }
            if (gameManager.BreakfastChoice == 3)
            {
                breakfastscore = 8;
            }
            if (gameManager.BreakfastChoice == 4)
            {
                breakfastscore = 0;
            }
            if (gameManager.BreakfastChoice == 5)
            {
                breakfastscore = 10;
            }
            if (gameManager.BreakfastChoice == 6)
            {
                breakfastscore = 4;
            }

        }
        if (gameManager.LunchChoice != 0)
        {
            if (gameManager.LunchChoice == 4)
            {
                lunchscore = 0;
            }
            if (gameManager.LunchChoice == 6)
            {
                lunchscore = 2;
            }
            if (gameManager.LunchChoice == 2)
            {
                lunchscore = 4;
            }
            if (gameManager.LunchChoice == 5)
            {
                lunchscore = 6;
            }
            if (gameManager.LunchChoice == 3)
            {
                lunchscore = 8;
            }
            if (gameManager.LunchChoice == 1)
            {
                lunchscore = 10;
            }
        }
        if (gameManager.SnackChoice != 0)
        {
            if (gameManager.SnackChoice == 4)
            {
                snackscore = 0;
            }
            if (gameManager.SnackChoice == 6)
            {
                snackscore = 2;
            }
            if (gameManager.SnackChoice == 1)
            {
                snackscore = 4;
            }
            if (gameManager.SnackChoice == 5)
            {
                snackscore = 6;
            }
            if (gameManager.SnackChoice == 3)
            {
                snackscore = 8;
            }
            if (gameManager.SnackChoice == 2)
            {
                snackscore = 10;
            }
        }
        if (gameManager.mPlaytimescore >= 0)
        {
            if (gameManager.mPlaytimescore == 0)
            {
                morningplayscore = 1;
            }
            if (gameManager.mPlaytimescore == 1)
            {
                morningplayscore = 4;
            }
            if (gameManager.mPlaytimescore == 2)
            {
                morningplayscore = 7;
            }
            if (gameManager.mPlaytimescore == 3)
            {
                morningplayscore = 10;
            }
        }
        if (gameManager.aPlaytimescore >= 0)
        {
            if (gameManager.aPlaytimescore == 0)
            {
                afternoonplayscore = 1;
            }
            if (gameManager.aPlaytimescore == 1)
            {
                afternoonplayscore = 4;
            }
            if (gameManager.aPlaytimescore == 2)
            {
                afternoonplayscore = 7;
            }
            if (gameManager.aPlaytimescore == 3)
            {
                afternoonplayscore = 10;
            }
        }
        if (gameManager.diaper1changed == true)
        {
            if (gameManager.diaper2changed == true)
            {
                diaperscore = 10;
            }
            else
            {
                diaperscore = 5;
            }
        }
        else
        {
            if (gameManager.diaper2changed == true)
            {
                diaperscore = 5;
            }
            else
            {
                diaperscore = 0;
            }
        }
        if (gameManager.GoodBook == true)
        {
            bookscore = 10;
        }
        else
        {
            bookscore = 0;
        }
        finalscore = breakfastscore + lunchscore + snackscore  + bookscore + diaperscore + morningplayscore + afternoonplayscore;

        Invoke("GiveBreakfastScore", 1f);
        Invoke("GiveLunchScore", 3f);
        Invoke("GiveSnackScore", 5f);
        Invoke("GivemPlayScore", 7f);
        Invoke("GiveaPlayScore", 9f);
        Invoke("GiveBookScore", 11f);
        Invoke("GiveDiaperScore", 13f);
        Invoke("GiveFinalScore", 15f);

    }


    // Update is called once per frame
    void Update()
    {
        
        
    }






    //------------------------------------------------------------------------------------- conjunction junction whats your function 
    public void BreakfastScore(int score)
    {

        Breakfast.text = score.ToString();
        Momreactions(score);

    }
    public void LunchScore(int score)
    {
        Lunch.text = score.ToString();
        Momreactions(score);
    }
    public void SnackScore(int score)
    {
        Snack.text = score.ToString();
        Momreactions(score);
    }
    public void mPlayScore(int score)
    {
        MorningPlay.text = score.ToString();
        Momreactions(score);
    }

    public void BookScore(int score)
    {
        Book.text = score.ToString();
        Momreactions(score);
    }
    public void DiaperScore(int score)
    {
        Diaper.text = score.ToString();
        Momreactions(score);
    }
    public void aPlayScore(int score)
    {
        AfternoonPlay.text = score.ToString();
        Momreactions(score);
    }
   
    public void FinalScore(int score)
    {
        Final.text = score.ToString();
        MomreactionsFinal(score);
        Invoke("Momspeak", 3f);

    }
    public void Momspeak()
    {
        GameObject.FindGameObjectWithTag("bubble").GetComponent<Image>().enabled = true;
        MomreactionsFinal(finalscore);
        if(finalscore == 70)
        {
            Audio.me.PlaySound(yay);
        }
        
    }




    public void GiveBreakfastScore()
    {
        BreakfastScore(breakfastscore);
    }
    public void GiveLunchScore()
    {
        LunchScore(lunchscore);
    }
    public void GiveSnackScore()
    {
        SnackScore(snackscore);
    }
    public void GivemPlayScore()
    {
        mPlayScore(morningplayscore);
    }
    public void GiveaPlayScore()
    {
        aPlayScore(afternoonplayscore);
    }
    public void GiveBookScore()
    {
        BookScore(bookscore);
    }
    public void GiveDiaperScore()
    {
        DiaperScore(diaperscore);
    }
    public void GiveFinalScore()
    {
        FinalScore(finalscore);
    }








    public void Momreactions(int score)
    {
        if(score <= 3)
        {
            reactions.Madmom();
            Audio.me.PlaySound(mommad);
        }
        else if (score <= 6)
        {
            reactions.Sadmom();
            Audio.me.PlaySound(momsad);
        }
        else if (score <= 9)
        {
            reactions.Okaymom();
            Audio.me.PlaySound(momokay);
        }
        if (score == 10)
        {
            reactions.Happymom();
            Audio.me.PlaySound(momhappy);
        }
    }
    public void MomreactionsFinal(int score)
    {
        if (score <= 10)
        {
            reactions.Madmom();
            Audio.me.PlaySound(mommad);
        }
        else if (score <= 30)
        {
            reactions.Sadmom();
            Audio.me.PlaySound(momsad);
        }
        else if (score <= 50)
        {
            reactions.Okaymom();
            Audio.me.PlaySound(momokay);
        }
        if (score == 70)
        {
            reactions.Happymom();
            Audio.me.PlaySound(momhappy);
            
        }
    }

}
