using UnityEngine;
using UnityEngine.UI;

public class SliderUI : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text valueText;

    public void Initialize(float minValue, float maxValue, float startValue, string labelText)
    {
        slider.minValue = minValue;
        slider.maxValue = maxValue;
        slider.value = startValue;

        if (valueText != null)
        {
            valueText.text = startValue.ToString();
        }

        if (!string.IsNullOrEmpty(labelText))
        {
            GetComponentInChildren<Text>().text = labelText;
        }
    }

    public float GetValue()
    {
        return slider.value;
    }

    public void SetValue(float value)
    {
        slider.value = value;

        if (valueText != null)
        {
            valueText.text = value.ToString();
        }
    }
}