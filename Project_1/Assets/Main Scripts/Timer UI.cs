using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    
    public CollactableManager CollactableManager;
    // Start is called before the first frame update
    public float timervalue = 90f;
    public bool isTimerRunning =false;
    public float currentTime;

    public Text timerText;
    
    void Start()
    {
        isTimerRunning = true;
        currentTime = timervalue;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerRunning)
        {
            currentTime = currentTime - Time.deltaTime;
            if (currentTime <= 0.0f && !CollactableManager.allCoinsCollected)
            {
                currentTime = 0.0f;
                isTimerRunning = false;
                Debug.Log("Game Lost");
                GameManager.instance.GameoverScreen(false);
            }
            if (CollactableManager.allCoinsCollected)
            {
                Debug.Log("Game Won");
                GameManager.instance.GameoverScreen(true);
                isTimerRunning = false ;
                
            }
        } UpdateTimerText();
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
