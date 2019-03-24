using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScore : MonoBehaviour
{
    float startY = 0;
    Rigidbody2D rb;

    public float speed = 1;

    bool moving = true;

    void Start()
    {
        rb = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        startY = transform.position.y;
        transform.position = new Vector2(transform.position.x, transform.position.y + 40);
        rb.AddForce(transform.up * -speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= startY&&moving)
        {
            print(startY);
            print(transform.position.y);
            rb.velocity = Vector3.zero;
            moving = false;
        }
    }
}
