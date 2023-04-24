using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StaggeredGridLayoutGroup : GridLayoutGroup
{
    public override void CalculateLayoutInputVertical()
    {
        base.CalculateLayoutInputVertical();

        float totalWidth = rectTransform.rect.width - padding.left - padding.right;
        int columnCount = Mathf.FloorToInt((totalWidth + spacing.x) / (cellSize.x + spacing.x));
        columnCount = Mathf.Max(1, columnCount);
        int[] columnHeights = new int[columnCount];

        int rowCount = 0;
        int currentColumn = 0;
        float currentPosition = 0f;

        for (int i = 0; i < rectChildren.Count; i++)
        {
            RectTransform child = rectChildren[i];

            if (child.gameObject.activeSelf)
            {
                LayoutElement layoutElement = child.GetComponent<LayoutElement>();

                float childWidth = layoutElement.minWidth;
                float childHeight = layoutElement.minHeight;

                if (currentColumn > 0)
                {
                    currentPosition += spacing.x;
                }

                if (currentColumn >= columnCount)
                {
                    currentColumn = 0;
                    rowCount++;
                    currentPosition = 0f;
                }

                currentPosition += childWidth * 0.5f;

                int columnHeight = columnHeights[currentColumn];
                child.anchoredPosition = new Vector2(currentPosition, -columnHeight - childHeight * 0.5f);
                columnHeights[currentColumn] += Mathf.RoundToInt(childHeight + spacing.y);

                currentColumn++;

                rowCount = Mathf.Max(rowCount, columnHeights.Max() / Mathf.RoundToInt(cellSize.y + spacing.y));
            }
        }

        float totalHeight = columnHeights.Max() + padding.top + padding.bottom;
        int rows = Mathf.CeilToInt(totalHeight / (cellSize.y + spacing.y));

        SetLayoutInputForAxis(totalWidth, totalWidth, -1, 1);
        SetLayoutInputForAxis(totalHeight, totalHeight, -1, 1);
    }
}
