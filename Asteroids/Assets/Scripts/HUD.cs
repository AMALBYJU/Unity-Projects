using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField]
    Text scoreText;

    string prefixScoreText = "Score: ";
    int score = 0;
    float elapsedTime = 0f;
    bool timerRunning = true;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = prefixScoreText + "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            elapsedTime += Time.deltaTime;
            score = (int)elapsedTime;
            scoreText.text = prefixScoreText + score.ToString();
        }
    }

    public void StopGameTimer()
    {
        timerRunning = false;
    }
}
