using UnityEngine;
using System.Collections;

public class PauseScreen : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickExit()
    {
        Application.Quit();
    }

    public void newGame()
    {
        Application.LoadLevel("MainScene");
        Time.timeScale = 1.0f;
    }

}
