using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSelector : MonoBehaviour
{
    public Text hourText;
    public Text minuteText;

    private int hour;
    private int minute;

    // Start is called before the first frame update
    void Start()
    {
        // Set initial time to current time
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;

        UpdateTimeText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementHour()
    {
        hour = (hour + 1) % 24; // Increment hour, wrapping around at 24
        UpdateTimeText();
    }

    public void DecrementHour()
    {
        hour = (hour + 23) % 24; // Decrement hour, wrapping around at 0
        UpdateTimeText();
    }

    public void IncrementMinute()
    {
        minute = (minute + 1) % 60; // Increment minute, wrapping around at 60
        UpdateTimeText();
    }

    public void DecrementMinute()
    {
        minute = (minute + 59) % 60; // Decrement minute, wrapping around at 0
        UpdateTimeText();
    }

    private void UpdateTimeText()
    {
        // Update hour and minute text fields
        hourText.text = hour.ToString("D2");
        minuteText.text = minute.ToString("D2");
    }

    public int GetHour()
    {
        return hour;
    }

    public int GetMinute()
    {
        return minute;
    }
}