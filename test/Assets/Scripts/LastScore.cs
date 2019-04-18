using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour
{
    Text lastScoreText;

    // Start is called before the first frame update
    void Start()
    {
        lastScoreText = GameObject.FindGameObjectWithTag("LastScore").GetComponent<Text>();
        lastScoreText.text = "Last Score\n" + (PlayerPrefs.GetInt("LastScore", 0) - 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
