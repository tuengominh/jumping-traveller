using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameEngine game;
    public float speed = 0;
    public float switchTime = 1;
    public Transform obs;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        InvokeRepeating("Switch", 0, switchTime);
    }

    void Switch() {
        if (obs.position.y <= 13f && obs.position.y >= 0f) {
            GetComponent<Rigidbody2D>().velocity *= -1;
        }
    }
}
