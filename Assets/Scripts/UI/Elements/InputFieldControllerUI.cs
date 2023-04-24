using UnityEngine;
using UnityEngine.UI;

public class InputFieldControllerUI : MonoBehaviour
{
    // Reference to the InputField component
    private InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to the InputField component
        inputField = GetComponent<InputField>();

        // Add a listener to the InputField to detect when the text has changed
        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
    }

    // Method that gets called when the text value of the InputField has changed
    private void OnInputFieldValueChanged(string newValue)
    {
        // Do something with the new value, such as update a text label or save it to a variable
        Debug.Log("InputField value changed to: " + newValue);
    }
}