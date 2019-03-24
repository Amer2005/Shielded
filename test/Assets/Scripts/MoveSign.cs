using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSign : MonoBehaviour
{
    int counter = 0;
    public int counterMax = 10;
    public float speed = 0.1f;
    float goTo;

    RectTransform pos;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        pos = gameObject.GetComponent(typeof(RectTransform)) as RectTransform;
        goTo = pos.position.y + 300;
    }

    // Update is called once per frame
    void Update()
    {
        if(pos.position.y >= goTo)
        {
            rb.velocity = Vector3.zero;
            SceneManager.LoadScene("Game");
        }
    }

    public void ButtonClick()
    {
        rb.AddForce(transform.up * speed);
    }
}
