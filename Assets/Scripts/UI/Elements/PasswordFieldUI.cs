using UnityEngine;
using UnityEngine.UI;

public class PasswordFieldUI : MonoBehaviour
{
    public InputField passwordField;

    void Start()
    {
        // Set up the input field for password entry
        passwordField.contentType = InputField.ContentType.Password;
        passwordField.lineType = InputField.LineType.SingleLine;
        passwordField.characterLimit = 20; // Optional, set as desired
        passwordField.placeholder.GetComponent<Text>().text = "Enter password";
        passwordField.textComponent.alignment = TextAnchor.MiddleCenter;
        passwordField.textComponent.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        passwordField.textComponent.fontSize = 24;
    }
}