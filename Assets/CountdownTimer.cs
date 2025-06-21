using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; //  Add this line


public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60f; // 60 seconds
    public TextMeshProUGUI timerText;
    private bool timerIsRunning = true;

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
                timeRemaining = 0;
                timerIsRunning = false;
                UpdateTimerDisplay(timeRemaining);
                TimerEnded();
            }
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        timeToDisplay = Mathf.Max(timeToDisplay, 0);

        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimerEnded()
    {
        Debug.Log("Time's up!");
        SceneManager.LoadScene("GameOver");
    }
}

