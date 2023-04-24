using UnityEngine;
using UnityEngine.UI;

public class CheckBoxUI : MonoBehaviour
{
    [SerializeField] private Image checkboxImage;
    [SerializeField] private Toggle checkboxToggle;
    [SerializeField] private Text checkboxLabel;

    private void Start()
    {
        checkboxToggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool value)
    {
        checkboxImage.color = value ? Color.white : Color.gray;
    }

    public void SetLabel(string label)
    {
        checkboxLabel.text = label;
    }
}