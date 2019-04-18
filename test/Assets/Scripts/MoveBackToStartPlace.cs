using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackToStartPlace : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    RectTransform pos;
    float maxMove = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Menu");
        //maxMove = pos.position.y;
        rb = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        pos = gameObject.GetComponent(typeof(RectTransform)) as RectTransform;
        maxMove = pos.position.y;
        if(speed > 0)
        {
            pos.position = new Vector3(pos.position.x, -Screen.currentResolution.height * 0.1f, 0);
        }
        if (speed < 0)
        {
            pos.position = new Vector3(pos.position.x, Screen.currentResolution.height * 1.1f, 0);
        }
        rb.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if((pos.position.y >= maxMove&&speed > 0)||(pos.position.y <= maxMove&&speed < 0))
        {
            rb.velocity = Vector3.zero;
        }
    }
}
