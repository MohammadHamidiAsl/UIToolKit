using UnityEngine;
using UnityEngine.UI;

public class LabelUI : MonoBehaviour
{
    [SerializeField] private Text label;

    public void SetText(string text)
    {
        label.text = text;
    }
}