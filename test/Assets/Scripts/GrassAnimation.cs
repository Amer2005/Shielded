using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassAnimation : MonoBehaviour {

    Animator anim;

    bool started = false;

    int br = 0;

    int numBeforStart = 50;

    private void FixedUpdate()
    {
        int randomStart = Random.Range(1, 40);
        if (randomStart == 1 && started == false)
        {
            anim = GetComponent<Animator>();
            anim.SetBool("startAnimation", true);
            started = true;
        }
        else if(started == false)
        {
            br++;
            if (br > numBeforStart)
            {
                randomStart = Random.Range(1, 2);
                if (randomStart == 1 && started == false)
                {
                    anim = GetComponent<Animator>();
                    anim.SetBool("startAnimation", true);
                    started = true;
                }
                else if (br > numBeforStart * 5&& started == false)
                {
                    anim = GetComponent<Animator>();
                    anim.SetBool("startAnimation", true);
                    started = true;
                }
            }
        }
    }
}
