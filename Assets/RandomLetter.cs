using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RandomLetter : MonoBehaviour {

    public bool Hit1;
    public bool Hit2;

    public string LetterLetter1;
    public string LetterLetter2;

    public int Score1;
    public int Score2;

    public string[] Letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    void Start () {
        Hit1 = false;
        Hit2 = false;

        Score1 = 0;
        Score2 = 0;

        var RandomLetter1 = Random.Range(1, 26);
        var RandomLetter2 = Random.Range(1, 26);
        LetterLetter1 = Letters[RandomLetter1];
        LetterLetter2 = Letters[RandomLetter2];
        GameObject.Find("Player 1 Letter").GetComponent<Text>().text = LetterLetter1;
        GameObject.Find("Player 2 Letter").GetComponent<Text>().text = LetterLetter2;
        Hit1 = false;
    }
	
	void Update () {
        Player1Stuff();
        Player2Stuff();
    }

    void Player1Stuff()
    {
        if (Input.GetKey(KeyCode.A) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "A")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.B) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "B")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.C) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "C")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.D) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "D")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.E) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "E")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.F) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "F")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.G) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "G")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.H) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "H")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.I) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "I")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.J) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "J")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.K) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "K")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.L) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "L")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.M) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "M")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.N) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "N")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.O) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "O")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.P) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "P")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.Q) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "Q")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.R) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "R")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.S) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "S")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.T) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "T")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.U) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "U")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.V) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "V")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.W) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "W")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.X) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "X")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.Y) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "Y")
        {
            Hit1 = true;
        }
        else if (Input.GetKey(KeyCode.Z) && GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "Z")
        {
            Hit1 = true;
        }

        if (Hit1 == true)
        {
            var RandomLetter = Random.Range(1, 26);
            LetterLetter1 = Letters[RandomLetter];
            Score1 += 5;
            GameObject.Find("Player 1 Score").GetComponent<Text>().text = Score1.ToString();
            GameObject.Find("Player 1 Letter").GetComponent<Text>().text = LetterLetter1;
            Hit1 = false;
        }
    }

    void Player2Stuff()
    {
        if (Input.GetKey(KeyCode.A) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "A")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.B) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "B")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.C) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "C")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.D) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "D")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.E) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "E")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.F) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "F")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.G) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "G")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.H) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "H")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.I) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "I")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.J) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "J")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.K) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "K")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.L) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "L")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.M) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "M")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.N) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "N")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.O) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "O")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.P) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "P")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.Q) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "Q")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.R) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "R")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.S) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "S")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.T) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "T")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.U) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "U")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.V) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "V")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.W) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "W")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.X) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "X")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.Y) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "Y")
        {
            Hit2 = true;
        }
        else if (Input.GetKey(KeyCode.Z) && GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "Z")
        {
            Hit2 = true;
        }

        if (Hit2 == true)
        {
            var RandomLetter = Random.Range(1, 26);
            LetterLetter2 = Letters[RandomLetter];
            Score2 += 5;
            GameObject.Find("Player 2 Score").GetComponent<Text>().text = Score2.ToString();
            GameObject.Find("Player 2 Letter").GetComponent<Text>().text = LetterLetter2;
            Hit2 = false;
        }
    }
}
