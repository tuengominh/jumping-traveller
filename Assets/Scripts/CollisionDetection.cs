using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    int collisionCount = 1;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Building")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Collision detected: " + collisionCount);
            collisionCount++;
        }
    }
}
