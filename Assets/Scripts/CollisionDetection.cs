using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameEngine game;
    private int obstacleCollisionCount = 1;
    private int pieceCollected = 1;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Building")
        {
            Debug.Log("Collision detected: " + obstacleCollisionCount);
            obstacleCollisionCount++;
            game.modifyState(0);
        }
        else if (col.gameObject.tag == "Piece")
        {
            Debug.Log("Piece collected: " + pieceCollected);
            Destroy(col.gameObject);
            pieceCollected++;
            game.modifyState(1);
        }
        else if (col.gameObject.tag == "Paella")
        {
            Debug.Log("Paella");
            Destroy(col.gameObject);
            game.modifyState(2);
        }
        else if (col.gameObject.tag == "Hourglass")
        {
            Debug.Log("Hourglass");
            Destroy(col.gameObject);
            game.modifyState(3);
        }
    }
}
