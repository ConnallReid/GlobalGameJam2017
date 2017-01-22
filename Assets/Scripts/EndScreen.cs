using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EndScreen : MonoBehaviour {

    public float speed = 100f;

    public bool fall = false;

    void Update()
    {
        if (GameObject.Find("Timer").GetComponent<Text>().text == "3")
        {
            fall = true;
        }
        if (fall == true)
        {
            transform.position += new Vector3(0.0f, -50 * speed * Time.deltaTime, 0.0f);
        }
    }
}
