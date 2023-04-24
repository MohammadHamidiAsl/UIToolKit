using UnityEngine;
using UnityEngine.UI;

public class RadioButtonUI : MonoBehaviour
{
    public Toggle toggleOption1;
    public Toggle toggleOption2;
    
    public void OnOption1Selected(bool selected)
    {
        if (selected)
        {
            Debug.Log("Option 1 selected");
        }
    }

    public void OnOption2Selected(bool selected)
    {
        if (selected)
        {
            Debug.Log("Option 2 selected");
        }
    }
}