using UnityEngine;
using UnityEngine.UI;

public class IconButtonUI : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private Button button;
    [SerializeField] private float _size = 100f;

    private Button _button;
    private RectTransform _rectTransform;
    
    private void Awake()
    {
        _button = GetComponent<Button>();
        _rectTransform = GetComponent<RectTransform>();

        _rectTransform.sizeDelta = new Vector2(_size, _size);
    }
    public void SetSize(float size)
    {
        _size = size;
        _rectTransform.sizeDelta = new Vector2(_size, _size);
    }
    public void SetIcon(Sprite icon)
    {
        iconImage.sprite = icon;
    }

    public void AddListener(UnityEngine.Events.UnityAction action)
    {
        button.onClick.AddListener(action);
    }
}