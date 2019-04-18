using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    // Start is called before the first frame update

    Text hightScoreText;
    
    void Start()
    {
        hightScoreText = GameObject.FindGameObjectWithTag("HighScore").GetComponent<Text>();
        hightScoreText.text = "High Score\n" + (PlayerPrefs.GetInt("HeightScore", 0) - 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
