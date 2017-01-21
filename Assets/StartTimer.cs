using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartTimer : MonoBehaviour {

    public float time = 300.0f;
    public float seconds;

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
    }
}
