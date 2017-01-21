using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

    public void PlayAgain()
    {
        Application.LoadLevel("MainScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
