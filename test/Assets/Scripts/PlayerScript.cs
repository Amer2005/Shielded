using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    private int scoreNow = 0;

    bool pressed = true;

    bool scoreDelay = false;

    int untilDelay = 0;
    int maxDelay = 25;

    public static string looking = "Right";

    public static float shieldRightX, shieldLeftX,playerRightX,playerLeftX;

    public GameObject shield;

    // Use this for initialization
    void Start () {
        shieldRightX = shield.transform.position.x;
        playerRightX = transform.position.x;
        transform.localRotation *= Quaternion.Euler(0, 180, 0);
        //0 - right 
        //-1 - left
        shieldLeftX = shield.transform.position.x;
        playerLeftX = transform.position.x;
        transform.localRotation *= Quaternion.Euler(0, 180, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if ((int)Math.Round(transform.rotation.y) == 0)
        {
            looking = "Right";
        }
        if ((int)Math.Round(transform.rotation.y) == -1)
        {
            looking = "Left";
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            leftTurn();
        }
        if(Input.GetKey("d"))
        {
            rightTurn();
        }
    }

    public void leftTurn()
    {
        if ((int)Math.Round(transform.rotation.y) == 0)
        {
            transform.localRotation *= Quaternion.Euler(0, 180, 0);
        }
    }

    public void rightTurn()
    {
        if ((int)Math.Round(transform.rotation.y) == -1)
        {
            transform.localRotation *= Quaternion.Euler(0, 180, 0);
        }
    }

}
