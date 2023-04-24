using UnityEngine;
using UnityEngine.UI;

public class DividerUI : MonoBehaviour
{
    [SerializeField] private Image dividerImage;

    public Color DividerColor
    {
        get { return dividerImage.color; }
        set { dividerImage.color = value; }
    }

    public float DividerThickness
    {
        get { return GetComponent<LayoutElement>().preferredHeight; }
        set { GetComponent<LayoutElement>().preferredHeight = value; }
    }
}