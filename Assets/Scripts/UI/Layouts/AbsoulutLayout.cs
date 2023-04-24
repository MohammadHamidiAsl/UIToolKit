using UnityEngine;
using UnityEngine.UI;

public class AbsoluteLayout : MonoBehaviour
{
    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void SetPosition(GameObject element, Vector2 position)
    {
        element.GetComponent<RectTransform>().anchoredPosition = position;
    }

    public void SetSize(GameObject element, Vector2 size)
    {
        element.GetComponent<RectTransform>().sizeDelta = size;
    }
}