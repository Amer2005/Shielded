using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    bool scoreDelay = false;

    int untilDelay = 0;
    int maxDelay = 25;
    public static int scoreNow = 0;

    private Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        scoreNow = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreDelay == true)
        {
            untilDelay++;
            if (untilDelay >= maxDelay)
            {
                untilDelay = 0;
                scoreDelay = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Arrow" && scoreDelay == false)
        {
            AddScore();
        }
    }

    private void AddScore()
    {
        scoreNow++;
        scoreDelay = true;
        score.text = "Score " + scoreNow;
        PlayerPrefs.SetInt("LastScore", scoreNow);
        if (scoreNow > PlayerPrefs.GetInt("HeightScore",0))
        {
            PlayerPrefs.SetInt("HeightScore", scoreNow);
        }
    }
}
