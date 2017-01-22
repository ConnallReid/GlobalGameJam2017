using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartTimer : MonoBehaviour {

    public float time = 300.0f;
    public float seconds;

    public Texture Three;
    public Texture Two;
    public Texture One;
    public Texture Go;

    void Start () {
        time = 3.5f;
    }

    void Update() {

        if (time > -1) { 
        time -= Time.deltaTime;
        seconds = Mathf.Round(time);
        }
        GameObject.Find("Start Timer").GetComponent<Text>().text = seconds.ToString();

        if (GameObject.Find("Start Timer").GetComponent<Text>().text == "0")
        {
            GameObject.Find("Start Timer").GetComponent<Text>().text = "Go!";
        }
        if (GameObject.Find("Start Timer").GetComponent<Text>().text == "-1")
        {
            GameObject.Find("Start Timer").GetComponent<Text>().text = "";
        }

        if (GameObject.Find("Start Timer").GetComponent<Text>().text == "3")
        {
            GameObject.Find("Start Number").GetComponent<RawImage>().texture = Three;
        }
        else if (GameObject.Find("Start Timer").GetComponent<Text>().text == "2")
        {
            GameObject.Find("Start Number").GetComponent<RawImage>().texture = Two;
        }
        else if (GameObject.Find("Start Timer").GetComponent<Text>().text == "1")
        {
            GameObject.Find("Start Number").GetComponent<RawImage>().texture = One;
        }
        else if (GameObject.Find("Start Timer").GetComponent<Text>().text == "Go!")
        {
            GameObject.Find("Start Number").GetComponent<RawImage>().texture = Go;
        }
        else
        {
            GameObject.Find("Start Number").SetActive(false);
        }
    }
}
