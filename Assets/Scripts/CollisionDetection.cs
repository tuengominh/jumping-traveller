using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    int obstacleCollisionCount = 1;
    int pieceCollected = 1;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Building")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Collision detected: " + obstacleCollisionCount);
            obstacleCollisionCount++;
            //TODO: reduce energy
        }
        else if (col.gameObject.tag == "Piece")
        {
            Debug.Log("Piece collected: " + pieceCollected);
            Destroy(col.gameObject);
            pieceCollected++;
        }
        else if (col.gameObject.tag == "Paella")
        {
            Debug.Log("Paella");
            Destroy(col.gameObject);
            //TODO: increase energy
        }
        else if (col.gameObject.tag == "Hourglass")
        {
            Debug.Log("Hourglass");
            Destroy(col.gameObject);
            //TOFO: increase time left
        }
    }
}
