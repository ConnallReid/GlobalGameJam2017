using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    //public int time;
    float time = 300.0f;

    void Start () {
        time = 0;
	}
	
	void Update () {

        time += Time.deltaTime;

        GameObject.Find("Timer").GetComponent<Text>().text = time.ToString();
    }
}
