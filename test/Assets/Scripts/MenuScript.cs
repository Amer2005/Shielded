using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text Score;
        Score = gameObject.GetComponent<Text>();
        Score.text = "Score " + ScoreScript.scoreNow.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
