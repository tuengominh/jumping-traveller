using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceInitialization : MonoBehaviour
{
    // public float speed = 8f;
    private float xPos = 20;
    private float yPos;
    public List<GameObject> pieces = new List<GameObject>();

    void Update()
    {
        try 
        {
            xPos += Random.Range(10,16);
            yPos = Random.Range(12,18);
            if (pieces.Count > 0) 
            {
                GameObject piece = pieces[Random.Range(0, pieces.Count - 1)];
                pieces.Remove(piece);
                Instantiate(piece, new Vector3(xPos,yPos,0), Quaternion.identity);
            }
        } 
        catch 
        {
            Debug.Log("Error!");
        }
    }
}
