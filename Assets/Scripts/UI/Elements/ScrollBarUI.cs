using UnityEngine;
using UnityEngine.UI;

public class ScrollBarUI : MonoBehaviour
{
    public ScrollRect targetScrollRect;

    private Scrollbar scrollbar;

    private void Start()
    {
        scrollbar = GetComponent<Scrollbar>();
        scrollbar.onValueChanged.AddListener(OnScrollBarValueChanged);
    }

    private void OnScrollBarValueChanged(float value)
    {
        targetScrollRect.verticalNormalizedPosition = value;
    }
}