using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float time = 100;
    public int timerSecounds = 15;

    void Start()
    {
        StartCoundownTimer(timerSecounds);
    }

    void StartCoundownTimer(int secounds)
    {
        if (timerText != null)
        {
            time = secounds;
            //timerText.text = "1:00:000";
            InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
        }
    }

    void UpdateTimer()
    {
        if (timerText != null)
        {
            time -= Time.deltaTime;
            string minutes = Mathf.Floor(time / 60).ToString("00");
            string seconds = (time % 60).ToString("00");
            string milisecounds = ((time * 100) % 100).ToString("000");
            timerText.text = minutes + ":" + seconds + ":" + milisecounds;

            int min;
            int sec;
            int mil;
            int.TryParse(minutes, out min);
            int.TryParse(seconds, out sec);
            int.TryParse(milisecounds, out mil);

            if(min <= 0 && sec <= 0 && mil <= 0) {
                CancelInvoke();
                StartCoundownTimer(timerSecounds);
            }

        }
    }
}
