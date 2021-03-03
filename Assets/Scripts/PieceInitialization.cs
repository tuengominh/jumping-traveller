using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceInitialization : MonoBehaviour
{
    public float init;
    float time = 1f;
    public float speed = 8f;

    public float prevXPos;
    public float xPos = 20;
    public float yPos;
    public List<GameObject> pieces = new List<GameObject>();

    void Update()
    {
        try {
            xPos = prevXPos + Random.Range(10,16);
            yPos = Random.Range(12,16);
            if (pieces.Count > 0) {
                GameObject piece = pieces[Random.Range(0, pieces.Count - 1)];
                pieces.Remove(piece);
                
                Instantiate(piece, new Vector3(xPos,yPos,0), Quaternion.identity);
                prevXPos = xPos;
            }
        } catch {
            Debug.Log("index out of range error");
        }
    }
}
