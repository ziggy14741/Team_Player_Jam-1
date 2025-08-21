using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Winorloss : MonoBehaviour
{
        public float timeRemaining = 10f;
        public bool timerIsRunning = false;
        public TextMeshProUGUI timerText;
    public Scorecount scorecount;
        void Start()
        {
            timerIsRunning = true;
        }

        void Update()
        {
            if (timerIsRunning)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                    UpdateTimerDisplay(timeRemaining);
                }
                else
                {
                    Debug.Log("Time's up!");
                    timerIsRunning = false;
                    timeRemaining = 0;
                    UpdateTimerDisplay(timeRemaining);
                scorecount.finalscore();
                    SceneManager.LoadScene("end credits");
                }
            }

        }


    void UpdateTimerDisplay(float timeToDisplay)
    {
        timeToDisplay = Mathf.Max(timeToDisplay, 0);
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);

        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timerText != null)
        {
            timerText.text = timeString;
        }
        else
        {
            Debug.Log("Time Remaining: " + timeString);
        }
    }
}
