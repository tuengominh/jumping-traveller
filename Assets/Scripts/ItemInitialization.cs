using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInitialization : MonoBehaviour
{
    public float init;
    float time = 1f;
    public float speed = 8f;

    public float xPos;
    public float prevXPos;
    public float yPos;
    public GameObject item;

    void Update()
    {
        try {
            xPos = prevXPos + Random.Range(15, 40);
            yPos = Random.Range(4,8);
            if (xPos <= 100f) {
                Instantiate(item, new Vector3(xPos,yPos,0), Quaternion.identity);
            } 
            prevXPos = xPos;
        } catch {
            Debug.Log("some error");
        }
    }
}
