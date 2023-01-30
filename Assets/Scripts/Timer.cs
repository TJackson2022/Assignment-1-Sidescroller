using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //public VictoryScript won;
    public TextMeshProUGUI timer;
    public float TimeLeft;
    public bool TimerIsOn = false;
    public bool isWon;
    void Start()
    {
        TimerIsOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerIsOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
                timer.text = TimeLeft.ToString("0");
            }
            else
            {
                Debug.Log("Timer is Done");
                TimeLeft = 0;
                //won.isWon = true;
                TimerIsOn = false;
            }
        }
    }
    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float seconds = Mathf.FloorToInt(currentTime % 60);
        float minutes = Mathf.FloorToInt(currentTime / 60);
        timer.text = string.Format("(0:00) : (1:00)", minutes, seconds);
    }
}
