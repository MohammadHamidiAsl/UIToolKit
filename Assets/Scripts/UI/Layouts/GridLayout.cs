using UnityEngine;
using UnityEngine.UI;

public class GridLayout : MonoBehaviour
{
    public int rows;
    public int columns;
    public float spacing;

    private GridLayoutGroup gridLayout;

    private void Awake()
    {
        gridLayout = GetComponent<GridLayoutGroup>();
    }

    private void Start()
    {
        ResizeGrid(rows, columns);
    }

    public void ResizeGrid(int newRows, int newColumns)
    {
        rows = newRows;
        columns = newColumns;

        gridLayout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
        gridLayout.constraintCount = columns;
        gridLayout.spacing = new Vector2(spacing, spacing);

        int cellCount = transform.childCount;
        int difference = (rows * columns) - cellCount;

        if (difference > 0)
        {
            for (int i = 0; i < difference; i++)
            {
                GameObject cell = new GameObject("Cell");
                cell.AddComponent<RectTransform>();
                cell.AddComponent<Image>();
                cell.transform.SetParent(transform);
            }
        }
        else if (difference < 0)
        {
            for (int i = 0; i < -difference; i++)
            {
                Destroy(transform.GetChild(cellCount - 1 - i).gameObject);
            }
        }

        gridLayout.enabled = false;
        gridLayout.enabled = true;
    }
}