using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public GameObject Camera;
    RandomLetter randomLetter;

    public float time = 300.0f;
    public float seconds;

    public GameObject Bar1A;
    public GameObject Bar1B;
    public GameObject Bar1C;
    public GameObject Bar1D;
    public GameObject Bar1E;
    public GameObject Bar1F;

    public GameObject Bar2A;
    public GameObject Bar2B;
    public GameObject Bar2C;
    public GameObject Bar2D;
    public GameObject Bar2E;
    public GameObject Bar2F;

    public GameObject ExitButton;
    public GameObject PlayAgainButton;

    public bool win;

    public bool Exit=false;
    public bool PlayAgain=false;

    void Start () {
        Camera = GameObject.Find("Main Camera");
        randomLetter = Camera.GetComponent<RandomLetter>();
        GameObject.Find("Win").GetComponent<Text>().text = "";

        time = 40;

        GameObject.Find("Timer").GetComponent<Text>().text = time.ToString();

        Bar1A = GameObject.Find("Bar1A");
        Bar1B = GameObject.Find("Bar1B");
        Bar1C = GameObject.Find("Bar1C");
        Bar1D = GameObject.Find("Bar1D");
        Bar1E = GameObject.Find("Bar1E");
        Bar1F = GameObject.Find("Bar1F");

        Bar2A = GameObject.Find("Bar2A");
        Bar2B = GameObject.Find("Bar2B");
        Bar2C = GameObject.Find("Bar2C");
        Bar2D = GameObject.Find("Bar2D");
        Bar2E = GameObject.Find("Bar2E");
        Bar2F = GameObject.Find("Bar2F");

        ExitButton = GameObject.Find("Quit Game");
        PlayAgainButton = GameObject.Find("Reset Game");

        Bar1A.SetActive(false);
        Bar1B.SetActive(false);
        Bar1C.SetActive(false);
        Bar1D.SetActive(false);
        Bar1E.SetActive(false);
        Bar1F.SetActive(false);

        Bar2A.SetActive(false);
        Bar2B.SetActive(false);
        Bar2C.SetActive(false);
        Bar2D.SetActive(false);
        Bar2E.SetActive(false);
        Bar2F.SetActive(false);

        win = false;
    }

    void Update()
    {
        if (Exit == true)
        {
            ExitButton.SetActive(true);
        }
        if (Exit == false)
        {
            ExitButton.SetActive(false);
        }

        if (PlayAgain == true)
        {
            PlayAgainButton.SetActive(true);
        }
        if (PlayAgain == false)
        {
            PlayAgainButton.SetActive(false);
        }

        Bar1();
        Bar2();

        Camera = GameObject.Find("Main Camera");
        if (randomLetter.Go == true)
        {
            if (time > 0 && win == false)
            {
                time -= Time.deltaTime;
                seconds = Mathf.Round(time);

                Exit = false;
                PlayAgain = false;

                GameObject.Find("Timer").GetComponent<Text>().text = seconds.ToString();
            }
            else
            {
                if (randomLetter.Score1 > randomLetter.Score2)
                {
                    GameObject.Find("Win").GetComponent<Text>().text = "Player 1 Wins!";
                }
                else if (randomLetter.Score1 < randomLetter.Score2)
                {
                    GameObject.Find("Win").GetComponent<Text>().text = "Player 2 Wins!";
                }
                else
                {
                    GameObject.Find("Win").GetComponent<Text>().text = "No Winners This Time!";
                }

                Exit = true;
                PlayAgain = true;
            }


        }
    }

    void Bar1()
    {
        if (randomLetter.Score1 - randomLetter.Score2 == 0)
        {
            Bar1A.SetActive(false);
            Bar1B.SetActive(false);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(false);
            Bar2B.SetActive(false);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score1 > randomLetter.Score2)
        {
            Bar1A.SetActive(true);
            Bar1B.SetActive(false);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(false);
            Bar2B.SetActive(false);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score1 - randomLetter.Score2 > 10)
        {
            Bar1A.SetActive(true);
            Bar1B.SetActive(true);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(false);
            Bar2B.SetActive(false);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score1 - randomLetter.Score2 > 20)
        {
            Bar1A.SetActive(true);
            Bar1B.SetActive(true);
            Bar1C.SetActive(true);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(false);
            Bar2B.SetActive(false);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score1 - randomLetter.Score2 > 30)
        {
            Bar1A.SetActive(true);
            Bar1B.SetActive(true);
            Bar1C.SetActive(true);
            Bar1D.SetActive(true);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(false);
            Bar2B.SetActive(false);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score1 - randomLetter.Score2 > 40)
        {
            Bar1A.SetActive(true);
            Bar1B.SetActive(true);
            Bar1C.SetActive(true);
            Bar1D.SetActive(true);
            Bar1E.SetActive(true);
            Bar1F.SetActive(false);

            Bar2A.SetActive(false);
            Bar2B.SetActive(false);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score1 - randomLetter.Score2 > 50)
        {
            Bar1A.SetActive(true);
            Bar1B.SetActive(true);
            Bar1C.SetActive(true);
            Bar1D.SetActive(true);
            Bar1E.SetActive(true);
            Bar1F.SetActive(true);

            Bar2A.SetActive(false);
            Bar2B.SetActive(false);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);

            win = true;
        }
    }

    void Bar2()
    {
        if (randomLetter.Score2 > randomLetter.Score1)
        {
            Bar1A.SetActive(false);
            Bar1B.SetActive(false);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(true);
            Bar2B.SetActive(false);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score2 - randomLetter.Score1 > 10)
        {
            Bar1A.SetActive(false);
            Bar1B.SetActive(false);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(true);
            Bar2B.SetActive(true);
            Bar2C.SetActive(false);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score2 - randomLetter.Score1 > 20)
        {
            Bar1A.SetActive(false);
            Bar1B.SetActive(false);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(true);
            Bar2B.SetActive(true);
            Bar2C.SetActive(true);
            Bar2D.SetActive(false);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score2 - randomLetter.Score1 > 30)
        {
            Bar1A.SetActive(false);
            Bar1B.SetActive(false);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(true);
            Bar2B.SetActive(true);
            Bar2C.SetActive(true);
            Bar2D.SetActive(true);
            Bar2E.SetActive(false);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score2 - randomLetter.Score1 > 40)
        {
            Bar1A.SetActive(false);
            Bar1B.SetActive(false);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(true);
            Bar2B.SetActive(true);
            Bar2C.SetActive(true);
            Bar2D.SetActive(true);
            Bar2E.SetActive(true);
            Bar2F.SetActive(false);
        }
        if (randomLetter.Score2 - randomLetter.Score1 > 50)
        {
            Bar1A.SetActive(false);
            Bar1B.SetActive(false);
            Bar1C.SetActive(false);
            Bar1D.SetActive(false);
            Bar1E.SetActive(false);
            Bar1F.SetActive(false);

            Bar2A.SetActive(true);
            Bar2B.SetActive(true);
            Bar2C.SetActive(true);
            Bar2D.SetActive(true);
            Bar2E.SetActive(true);
            Bar2F.SetActive(true);

            win = true;
        }
    }
}
