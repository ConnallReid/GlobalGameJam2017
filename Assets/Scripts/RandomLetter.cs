using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RandomLetter : MonoBehaviour {

    public Texture A;
    public Texture B;
    public Texture C;
    public Texture D;
    public Texture E;
    public Texture F;
    public Texture G;
    public Texture H;
    public Texture I;
    public Texture J;
    public Texture K;
    public Texture L;
    public Texture M;
    public Texture N;
    public Texture O;
    public Texture P;
    public Texture Q;
    public Texture R;
    public Texture S;
    public Texture T;
    public Texture U;
    public Texture V;
    public Texture W;
    public Texture X;
    public Texture Y;
    public Texture Z;

    public bool Hit1;
    public bool Hit2;

    public string LetterLetter1;
    public string LetterLetter2;

    public int Score1;
    public int Score2;

    public bool Go = false;

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
    }
	
	void Update () {

        if (GameObject.Find("Start Timer").GetComponent<Text>().text == "Go!")
        {
            Go = true;
        }

        if (GameObject.Find("Start Timer").GetComponent<Text>().text == "")
        {
            if (GameObject.Find("Win").GetComponent<Text>().text == "Player 1 Wins!")
            {

            }
            else if (GameObject.Find("Win").GetComponent<Text>().text == "Player 2 Wins!")
            {

            }
            else if (GameObject.Find("Win").GetComponent<Text>().text == "No Winners This Time!")
            {

            }
            else
            {
                Player1Stuff();
                Player2Stuff();
                Key1ToImage();
                Key2ToImage();
            }

            if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == GameObject.Find("Player 2 Letter").GetComponent<Text>().text)
            {
                var RandomLetter2 = Random.Range(1, 26);
                LetterLetter2 = Letters[RandomLetter2];
                GameObject.Find("Player 2 Letter").GetComponent<Text>().text = LetterLetter2;
            }
        }
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
            //GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = A;
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

    void Key1ToImage()
    {
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "A")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = A;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "B")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = B;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "C")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = C;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "D")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = D;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "E")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = E;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "F")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = F;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "G")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = G;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "H")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = H;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "I")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = I;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "J")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = J;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "K")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = K;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "L")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = L;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "M")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = M;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "N")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = N;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "O")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = O;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "P")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = P;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "Q")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = Q;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "R")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = R;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "S")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = S;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "T")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = T;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "U")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = U;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "V")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = V;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "W")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = W;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "X")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = X;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "Y")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = Y;
        }
        if (GameObject.Find("Player 1 Letter").GetComponent<Text>().text == "Z")
        {
            GameObject.Find("Player 1 Key").GetComponent<RawImage>().texture = Z;
        }
    }

    void Key2ToImage()
    {
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "A")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = A;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "B")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = B;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "C")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = C;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "D")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = D;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "E")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = E;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "F")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = F;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "G")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = G;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "H")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = H;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "I")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = I;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "J")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = J;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "K")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = K;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "L")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = L;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "M")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = M;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "N")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = N;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "O")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = O;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "P")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = P;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "Q")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = Q;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "R")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = R;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "S")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = S;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "T")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = T;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "U")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = U;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "V")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = V;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "W")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = W;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "X")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = X;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "Y")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = Y;
        }
        if (GameObject.Find("Player 2 Letter").GetComponent<Text>().text == "Z")
        {
            GameObject.Find("Player 2 Key").GetComponent<RawImage>().texture = Z;
        }
    }
}
