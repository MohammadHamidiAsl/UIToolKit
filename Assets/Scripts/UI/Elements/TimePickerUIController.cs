using UnityEngine;
using UnityEngine.UI;

public class TimePickerUIController : MonoBehaviour
{
    public Text selectedTimeText;
    public int initialHour;
    public int initialMinute;

    private int hour;
    private int minute;

    private void Start()
    {
        hour = initialHour;
        minute = initialMinute;
        UpdateSelectedTimeText();
    }

    public void IncrementHour()
    {
        hour = (hour + 1) % 24;
        UpdateSelectedTimeText();
    }

    public void DecrementHour()
    {
        hour = (hour + 23) % 24;
        UpdateSelectedTimeText();
    }

    public void IncrementMinute()
    {
        minute = (minute + 1) % 60;
        UpdateSelectedTimeText();
    }

    public void DecrementMinute()
    {
        minute = (minute + 59) % 60;
        UpdateSelectedTimeText();
    }

    private void UpdateSelectedTimeText()
    {
        selectedTimeText.text = hour.ToString("00") + ":" + minute.ToString("00");
    }
}