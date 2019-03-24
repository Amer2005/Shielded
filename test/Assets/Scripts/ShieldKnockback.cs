using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldKnockback : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    
    public float speed = 0.2f;
    public int counterStart = 10;
    int counter = -1;
    bool count = false;
    void Start()
    {
        rb = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        rb.isKinematic = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (count)
        {
            if (counter == 0)
            {
                rb.velocity = Vector3.zero;
                rb.AddForce(transform.right * speed);
            }
            if (counter == -(counterStart * 2))
            {
                rb.velocity = Vector3.zero;
                count = false;
            }
            counter--;
        }
        else
        {
            if((PlayerScript.shieldRightX < transform.position.x - 0.2|| PlayerScript.shieldRightX > transform.position.x + 0.2) && (PlayerScript.shieldLeftX < transform.position.x - 0.2 || PlayerScript.shieldLeftX > transform.position.x + 0.2))
            {
                if(PlayerScript.looking == "Right")
                {
                    transform.position = new Vector2(PlayerScript.shieldRightX, transform.position.y);
                }
                else
                {
                    transform.position = new Vector2(PlayerScript.shieldLeftX, transform.position.y);
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Arrow"&&count == false)
        {
            Rigidbody2D rb = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
            rb.AddForce(transform.right * -(speed * 2));
            counter = counterStart;
            count = true;
        }
    }
}
