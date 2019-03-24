using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawnScript : MonoBehaviour {

    public GameObject arrow;

    int br = 0;
    int toNextLevel = 0;
    public int brMax = 100;

    bool pressed = false;

	// Use this for initialization
	void Start () {
        br = brMax;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (br >= brMax)
        {
            br = 0;
            Instantiate(arrow);
        }
        if(toNextLevel % 150 == 0&&brMax > 20)
        {
            brMax -= 5;
        }
        toNextLevel++;
        br++;
    }

    public void buttonPress()
    {
        pressed = true;
    }
}
