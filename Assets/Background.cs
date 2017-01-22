using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Background : MonoBehaviour {

    public GameObject LeftWheel;
    public GameObject RightWheel;
    public GameObject WatterWheel;

    void Start () {
        LeftWheel = GameObject.Find("LeftWheel");
        RightWheel = GameObject.Find("RightWheel");
        WatterWheel = GameObject.Find("WatterWheel");
	}
	
	void Update () {
        LeftWheel.transform.Rotate(0, 20* Time.deltaTime, 0);
        RightWheel.transform.Rotate(0, 20 * Time.deltaTime, 0);
        WatterWheel.transform.Rotate(0, -10 * Time.deltaTime, 0);
    }
}
