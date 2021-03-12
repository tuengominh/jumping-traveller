using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEngine : MonoBehaviour
{
    public int level;
    public int pieceCollected = 0;
    public int energy = 8000;
    public int timeLeft = 12000;
    public int speed = 6;
    private bool gameOver = false;
    public GameObject gameOverUI;

    void Start()
    {
        gameOverUI.SetActive(false);
        if (level != 1) {
            energy = 5000;
            timeLeft = 10000;
        }
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
                SceneManager.LoadScene("Nivel2");
            }
        }
        else 
        {
            gameOverUI.SetActive(true);
            Application.Quit();
        }
    }

    public void die()
    {
        gameOver = true;  
    }

    public void modifyState(int col) {
        if (col == 0) 
        {
            energy = energy - 50;
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
        GUI.Box(new Rect(10, 10, 200, 20), "Level: " + level);
        GUI.Box(new Rect(10, 30, 200, 20), "Energy: " + energy);
        GUI.Box(new Rect(10, 50, 200, 20), "Time Left: " + timeLeft);
        GUI.Box(new Rect(10, 70, 200, 20), "Speed: " + speed);
        GUI.Box(new Rect(10, 90, 200, 20), "Pieces Collected: " + pieceCollected);
    }

}
