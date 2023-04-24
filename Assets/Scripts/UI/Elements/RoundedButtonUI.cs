using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class RoundedButtonUI : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Image backgroundUIImage;
    [SerializeField] private Image icon;
    [SerializeField] private Text _labelText;
    [SerializeField] private Color _normalColor;
    [SerializeField] private Color _highlightedColor;

    private void Start()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        Debug.Log("RoundedButton clicked!");
    }

    public void SetLabel(string label)
    {
        _labelText.text = label;
    }

    public void SetIcon(Sprite icon)
    {
        
        this.icon.sprite = icon;
    }

    public void SetColors(Color normalColor, Color highlightedColor)
    {
        _normalColor = normalColor;
        _highlightedColor = highlightedColor;
    }

    public void SetHighlighted(bool highlighted)
    {
        backgroundUIImage.color = highlighted ? _highlightedColor : _normalColor;
    }
}