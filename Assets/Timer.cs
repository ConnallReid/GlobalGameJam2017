using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    //public int time;
    public float time = 300.0f;
    public float seconds;

    void Start () {
        time = 40;
	}
	
	void Update () {

        if (time > 0)
        {
            time -= Time.deltaTime;
            seconds = Mathf.Round(time);

            GameObject.Find("Timer").GetComponent<Text>().text = seconds.ToString();
        }
        else
        {
            GameObject.Find("Timer").GetComponent<Text>().text = "Game Over";
        }
    }
}
