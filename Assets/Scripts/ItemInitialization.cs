using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInitialization : MonoBehaviour
{
    private int speed = 1;
    private float xPos = 35;
    private float yPos;
    public GameObject item;

    void Update()
    {
        try 
        {
            xPos += Random.Range(15, 35);
            yPos = Random.Range(4,8);
            if (xPos <= 100f) 
            {
                Instantiate(item, new Vector3(xPos,yPos,0), Quaternion.identity);
            } 
        } 
        catch 
        {
            Debug.Log("Error!");
        }
    }
}
