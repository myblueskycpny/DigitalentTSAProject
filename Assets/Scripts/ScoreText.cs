using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public static int score = 0;
    TMP_Text textScore;

    void Start()
    {
        textScore = GetComponent<TMP_Text>();
    }

    void Update()
    {
        textScore.text = "Score = " + score.ToString();
    }
}
