using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EscPressed : MonoBehaviour
{
    public GameObject escapeMenu;
    private bool isPaused;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Help from http://answers.unity3d.com/questions/850220/how-can-i-get-a-ui-canvas-to-hideappear-on-esc-but.html
        if (Input.GetKeyDown("escape"))
        {
            isPaused = !isPaused;
            escapeMenu.SetActive(isPaused);
            if (isPaused == true)
            {
                Time.timeScale = 0.0f;
            }
            else
            {
                Time.timeScale = 1.0f;
            }
        }
    }

    public void resumeGameButton()
    {
        escapeMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1.0f;
    }
}
