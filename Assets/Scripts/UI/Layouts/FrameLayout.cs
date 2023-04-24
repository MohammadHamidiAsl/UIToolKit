using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class FrameLayout : MonoBehaviour
{
    [SerializeField] private bool fitToParent = true;
    [SerializeField] private float padding = 10f;

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        if (fitToParent)
        {
            FitToParent();
        }
    }

    public void FitToParent()
    {
        var parentRect = transform.parent.GetComponent<RectTransform>();
        rectTransform.anchorMin = Vector2.zero;
        rectTransform.anchorMax = Vector2.one;
        rectTransform.offsetMin = new Vector2(padding, padding);
        rectTransform.offsetMax = new Vector2(-padding, -padding);
        rectTransform.sizeDelta = new Vector2(
            parentRect.rect.width - padding * 2,
            parentRect.rect.height - padding * 2);
    }
}