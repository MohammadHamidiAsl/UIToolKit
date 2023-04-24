using UnityEngine;
using UnityEngine.UI;

public class HeaderUI : MonoBehaviour
{
    [SerializeField] private Text titleText;

    public void SetTitle(string title)
    {
        titleText.text = title;
    }

    public void OnBackButtonClicked()
    {
        // Handle back button click
    }
}