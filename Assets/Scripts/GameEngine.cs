using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEngine : MonoBehaviour
{
    public int level = 0;
    public int pieceCollected = 0;
    public int energy;
    public int timeLeft;
    public int speed;
    private bool gameOver = false;
    public GameObject gameOverUI;

    void Start()
    {
        gameOverUI.SetActive(false);
        level = PlayerPrefs.GetInt("MyLevel");
        if (level == 0) {
            energy = 5000;
            timeLeft = 12000;
            speed = 5;
        } else {
            energy = 3000;
            timeLeft = 10000;
            speed = 3;
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
                level = 1;
                saveLevel();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

    public void saveLevel() {
        PlayerPrefs.SetInt("MyLevel",level);
    }

    public void modifyState(int col) {
        if (col == 0) 
        {
            energy = energy - 100;
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
        int displayLevel = level+1;
        GUI.Box(new Rect(10, 10, 200, 20), "Level: " + displayLevel);
        GUI.Box(new Rect(10, 30, 200, 20), "Energy: " + energy);
        GUI.Box(new Rect(10, 50, 200, 20), "Time Left: " + timeLeft);
        GUI.Box(new Rect(10, 70, 200, 20), "Speed: " + speed);
        GUI.Box(new Rect(10, 90, 200, 20), "Pieces Collected: " + pieceCollected);
    }

}
