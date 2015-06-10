using UnityEngine;
using System.Collections;

public class BallExit : MonoBehaviour {
    private int ballsDestroyed;
    private bool isOver;
    public GameObject overMenu;
    public GameObject win;
    public GameObject lose;
    
	// Use this for initialization
	void Start () 
    {
        ballsDestroyed = 0;
        isOver = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        overMenu.SetActive(isOver);
        if (isOver == true)
        {
            Time.timeScale = 0.0f;
        }
	}

    void OnTriggerEnter(Collider ball)
    {
        if(ball.name == "CueBall")
        {
            Destroy(ball.gameObject, 0.3f);
            isOver = true;
            lose.SetActive(true);
            //lose
        }
        if(ball.name == "8")
        {
            if(ballsDestroyed == 14)
            {
                Destroy(ball.gameObject, 0.3f);
                isOver = true;
                win.SetActive(true);

                //win
            }
            else
            {
                isOver = true;
                lose.SetActive(true);
                //lose
            }
        }
        
        else
        {
            Destroy(ball.gameObject, 0.3f);
            ballsDestroyed++;
        }
    }

    public void playAgain()
    {
        Application.LoadLevel("MainScene");
        isOver = false;
        Time.timeScale = 1.0f;
    }
}
