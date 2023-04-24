using UnityEngine;
using UnityEngine.UI;

public class TextAreaUI : MonoBehaviour
{
    private Text textComponent;

    public string Text
    {
        get { return textComponent.text; }
        set { textComponent.text = value; }
    }

    void Start()
    {
        textComponent = GetComponentInChildren<Text>();
    }
}