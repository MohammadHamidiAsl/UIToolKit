using UnityEngine;
using UnityEngine.UI;

public class ToolTipUI : MonoBehaviour
{
    [SerializeField] private Text toolTipText;

    public void SetToolTipText(string text)
    {
        toolTipText.text = text;
    }
}