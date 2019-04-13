using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOutOfScreenOnStart : MonoBehaviour
{
    public float speed = 5f;
    float goTo;
    RectTransform pos;
    Rigidbody2D rb;
    GameObject mainCanvas;
    Vector3[] corners = new Vector3[4];
    float maxMove;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = gameObject.GetComponent(typeof(RectTransform)) as RectTransform;
        pos.GetWorldCorners(corners);
        if (speed > 0)
        {
            maxMove = Screen.currentResolution.height * 1.1f;
        }
        else
        {
            maxMove = 0f - Screen.currentResolution.height * 0.1f;
        }
        rb.AddForce(transform.up * speed);
    }
    // Update is called once per frame
    void Update()
    {
        if ((pos.position.y >= maxMove && maxMove > 0) || (pos.position.y <= maxMove && maxMove < 0))
        {
            rb.velocity = Vector3.zero;
        }
    }
}
