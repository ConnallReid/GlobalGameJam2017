using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public GameObject Camera;
    RandomLetter randomLetter;

    public float time = 300.0f;
    public float seconds;

    void Start () {
        Camera = GameObject.Find("Main Camera");
        randomLetter = Camera.GetComponent<RandomLetter>();

        time = 40;
	}
	
	void Update () {

        Camera = GameObject.Find("Main Camera");


        if (time > 0)
        {
            time -= Time.deltaTime;
            seconds = Mathf.Round(time);

            GameObject.Find("Timer").GetComponent<Text>().text = seconds.ToString();
        }
        else
        {
            if (randomLetter.Score1 > randomLetter.Score2)
            {
                GameObject.Find("Timer").GetComponent<Text>().text = "Player 1 Wins!";
            }
            else if (randomLetter.Score1 < randomLetter.Score2)
            {
                GameObject.Find("Timer").GetComponent<Text>().text = "Player 2 Wins!";
            }
            else
            {
                GameObject.Find("Timer").GetComponent<Text>().text = "No Winners This Time!";
            }
        }
    }
}
