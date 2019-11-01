using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate:MonoBehaviour
{
    public static int scoreValues;
    Text score;

    private void Start()
    {
        scoreValues = 0;
        score = GetComponent<Text>();
    }
   
     void Update()
    {
        score.text = scoreValues.ToString();
    }
}