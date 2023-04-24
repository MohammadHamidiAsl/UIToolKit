using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform), typeof(Button))]
public class SquareButtonUI : MonoBehaviour
{
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

    public void AddClickListener(UnityEngine.Events.UnityAction listener)
    {
        _button.onClick.AddListener(listener);
    }
}