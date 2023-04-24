using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownUI : MonoBehaviour
{
    // A list of options to populate the dropdown with
    public List<string> options;

    // The Dropdown component of the UI element
    private Dropdown dropdown;

    // Called when the script is initialized
    void Awake()
    {
        // Get the Dropdown component of the UI element
        dropdown = GetComponent<Dropdown>();
    }

    // Called when the script is enabled
    void OnEnable()
    {
        // Populate the dropdown with the options list
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }

    // Called when a dropdown option is selected
    public void OnDropdownValueChanged()
    {
        // Get the currently selected option
        string selectedOption = dropdown.options[dropdown.value].text;

        // Do something with the selected option
        Debug.Log("Selected option: " + selectedOption);
    }
}