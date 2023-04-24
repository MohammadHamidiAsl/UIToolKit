using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DatePicker : MonoBehaviour
{
    public Text monthLabel;
    public Text yearLabel;
    public GameObject dayPrefab;
    public Transform dayContainer;
    public int startYear;
    public int endYear;

    private int currentMonth;
    private int currentYear;

    void Start()
    {
        currentMonth = DateTime.Now.Month;
        currentYear = DateTime.Now.Year;
        UpdateCalendar();
    }

    public void NextMonth()
    {
        currentMonth++;
        if (currentMonth > 12)
        {
            currentMonth = 1;
            currentYear++;
        }
        UpdateCalendar();
    }

    public void PreviousMonth()
    {
        currentMonth--;
        if (currentMonth < 1)
        {
            currentMonth = 12;
            currentYear--;
        }
        UpdateCalendar();
    }

    private void UpdateCalendar()
    {
        monthLabel.text = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
        yearLabel.text = currentYear.ToString();

        // Remove any existing day buttons
        foreach (Transform child in dayContainer)
        {
            Destroy(child.gameObject);
        }

        // Get the number of days in the current month
        int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

        // Create buttons for each day of the month
        for (int i = 1; i <= daysInMonth; i++)
        {
            GameObject dayButton = Instantiate(dayPrefab, dayContainer);
            dayButton.GetComponentInChildren<Text>().text = i.ToString();
        }
    }
}