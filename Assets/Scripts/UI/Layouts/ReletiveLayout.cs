using System.Collections.Generic;
using UnityEngine;

public class RelativeLayout : MonoBehaviour
{
    public enum AnchorPosition
    {
        TopLeft,
        TopCenter,
        TopRight,
        MiddleLeft,
        MiddleCenter,
        MiddleRight,
        BottomLeft,
        BottomCenter,
        BottomRight
    }

    public class RelativeLayoutElement
    {
        public RectTransform rectTransform;
        public AnchorPosition anchorPosition;
        public Vector2 offset;
    }

    public List<RelativeLayoutElement> elements = new List<RelativeLayoutElement>();

    private void Update()
    {
        foreach (RelativeLayoutElement element in elements)
        {
            SetElementPosition(element);
        }
    }

    private void SetElementPosition(RelativeLayoutElement element)
    {
        Vector2 anchorMin = new Vector2(0, 1);
        Vector2 anchorMax = new Vector2(0, 1);
        Vector2 pivot = new Vector2(0, 1);

        switch (element.anchorPosition)
        {
            case AnchorPosition.TopLeft:
                anchorMin = new Vector2(0, 1);
                anchorMax = new Vector2(0, 1);
                pivot = new Vector2(0, 1);
                break;
            case AnchorPosition.TopCenter:
                anchorMin = new Vector2(0.5f, 1);
                anchorMax = new Vector2(0.5f, 1);
                pivot = new Vector2(0.5f, 1);
                break;
            case AnchorPosition.TopRight:
                anchorMin = new Vector2(1, 1);
                anchorMax = new Vector2(1, 1);
                pivot = new Vector2(1, 1);
                break;
            case AnchorPosition.MiddleLeft:
                anchorMin = new Vector2(0, 0.5f);
                anchorMax = new Vector2(0, 0.5f);
                pivot = new Vector2(0, 0.5f);
                break;
            case AnchorPosition.MiddleCenter:
                anchorMin = new Vector2(0.5f, 0.5f);
                anchorMax = new Vector2(0.5f, 0.5f);
                pivot = new Vector2(0.5f, 0.5f);
                break;
            case AnchorPosition.MiddleRight:
                anchorMin = new Vector2(1, 0.5f);
                anchorMax = new Vector2(1, 0.5f);
                pivot = new Vector2(1, 0.5f);
                break;
            case AnchorPosition.BottomLeft:
                anchorMin = new Vector2(0, 0);
                anchorMax = new Vector2(0, 0);
                pivot = new Vector2(0, 0);
                break;
            case AnchorPosition.BottomCenter:
                anchorMin = new Vector2(0.5f, 0);
                anchorMax = new Vector2(0.5f, 0);
                pivot = new Vector2(0.5f, 0);
                break;
            case AnchorPosition.BottomRight:
                anchorMin = new Vector2(1, 0);
                anchorMax = new Vector2(1, 0);
                pivot = new Vector2(1, 0);
                break;
        }

        element.rectTransform.anchorMin = anchorMin;
        element.rectTransform.anchorMax = anchorMax;
        element.rectTransform.pivot = pivot;
        element.rectTransform.anchoredPosition = element.offset;
    }
}
