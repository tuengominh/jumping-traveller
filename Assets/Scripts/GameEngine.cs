using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEngine : MonoBehaviour
{
    // public int level = 1;
    public int pieceCollected = 0;
    public int energy = 5000;
    public int timeLeft = 12000;
    public int speed = 5;
    private bool gameOver = false;

    void Start()
    {
    
    }

    void Update()
    {
        if (gameOver == false)
        {
            energy--;
            timeLeft--;
            if (energy <= 0 || timeLeft <= 0 || speed <= 0)
            {
                die();
            }
            if (pieceCollected == 6) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                // TODO: setActive() NextLevel panel 
            }
        }
        else 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            // TODO: setActive() GameOver panel 
        }
    }

    public void die()
    {
        gameOver = true;  
    }

    public void modifyState(int col) {
        if (col == 0) 
        {
            energy = energy - 2;
            speed--;
        } 
        else if (col == 1) 
        {
            pieceCollected++;
        }
        else if (col == 2) 
        {
            energy = energy + 200;
            speed++;
        }
        else if (col == 3) 
        {
            timeLeft = timeLeft + 100;
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 200, 20), "Energy: " + energy);
        GUI.Box(new Rect(10, 30, 200, 20), "Time Left: " + timeLeft);
        GUI.Box(new Rect(10, 50, 200, 20), "Speed: " + speed);
        GUI.Box(new Rect(10, 70, 200, 20), "Pieces Collected: " + pieceCollected);
    }

}
