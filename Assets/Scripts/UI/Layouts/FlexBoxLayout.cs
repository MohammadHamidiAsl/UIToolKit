using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlexBoxLayout : MonoBehaviour
{
    public enum FlexBoxLayoutAxis
    {
        Horizontal,
        Vertical
    }
    public FlexBoxLayoutAxis axis = FlexBoxLayoutAxis.Horizontal;
    public float spacing = 10f;

    void Start()
    {
        RectTransform parentRectTransform = GetComponent<RectTransform>();
        int numChildren = parentRectTransform.childCount;
        float totalSpacing = spacing * (numChildren - 1);

        for (int i = 0; i < numChildren; i++)
        {
            RectTransform childRectTransform = parentRectTransform.GetChild(i).GetComponent<RectTransform>();

            if (axis == FlexBoxLayoutAxis.Horizontal)
            {
                float childWidth = (parentRectTransform.rect.width - totalSpacing) / numChildren;
                float childX = (childWidth + spacing) * i;
                childRectTransform.sizeDelta = new Vector2(childWidth, parentRectTransform.rect.height);
                childRectTransform.anchoredPosition = new Vector2(childX, 0f);
            }
            else
            {
                float childHeight = (parentRectTransform.rect.height - totalSpacing) / numChildren;
                float childY = (childHeight + spacing) * i;
                childRectTransform.sizeDelta = new Vector2(parentRectTransform.rect.width, childHeight);
                childRectTransform.anchoredPosition = new Vector2(0f, childY);
            }
        }
    }

}
