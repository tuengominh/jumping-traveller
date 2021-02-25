using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private SpriteRenderer rend;
    private Rigidbody2D body;
    public float speed = 3.0f;
    public float force = 300;

    void Start () {
        rend = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
    }

    void Update () {
        float f = Input.GetAxis("Horizontal");
        if (rend != null)
        {
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            if (transform.position.x >= 75f && x > 0) {
                rend.flipX = true;
                transform.Translate(0, 0, 0);
            } else if (transform.position.x < 0f && x < 0) {
                rend.flipX = true;
                transform.Translate(0, 0, 0);
            } else {
                transform.Translate(x, 0, 0);
                if (x < 0) {
                    rend.flipX = true;
                } else {
                    rend.flipX = false;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (transform.position.y <= 4.5f) 
            {
                body.AddForce(Vector2.up * force);
            }
        }
	}
}
