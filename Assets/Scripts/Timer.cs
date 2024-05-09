using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float TimeRemaining = 100;
    public bool TimerRunning = true;
    public TMP_Text TimeText;

    // Start is called before the first frame update
    void Start()
    {
        TimerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerRunning)
        {
            if (TimeRemaining > 0)
            {
                TimeRemaining -= Time.deltaTime;
                DisplayTime(TimeRemaining);
            }
        }

        if (TimeRemaining <= 0) 
        {
            SceneManager.LoadScene(0);
        }

    }

    void DisplayTime(float TimeDisplay)
    {
        TimeDisplay -= 1;
        float Minutes = Mathf.FloorToInt(TimeDisplay / 60);
        float Seconds = Mathf.FloorToInt(TimeDisplay % 60);
        TimeText.text = string.Format("{0:00} : {1:00}", Minutes, Seconds);
    }

}
