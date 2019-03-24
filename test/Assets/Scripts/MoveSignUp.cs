using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSignUp : MonoBehaviour
{
    double startY = -3.814;
    Rigidbody2D rb;

    public float speed = 1;
    RectTransform pos;
    void Start()
    {
        rb = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        pos = gameObject.GetComponent(typeof(RectTransform)) as RectTransform;
        startY = pos.position.y - 30;
        rb.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (pos.position.y <= startY)
        {
            //rb.velocity = Vector3.zero;
        }
    }
}
