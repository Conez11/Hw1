using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GUIText restartText;
    public GUIText gameOverText;

    private bool gameOver;
    private bool restart;
    //private int score;

    void Start ()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        //score = 0;
    }

    void Update ()
    {
        if (restart)
        {
            if (Input.GetKeyDown (KeyCode.R))
            {
                Application.LoadLevel (Application.loadedLevel);
            }
        }
		if (gameOver)
		{
			restartText.text = "Press 'R' for Restart";
			restart = true;
		}
    }

    public void GameOver ()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
