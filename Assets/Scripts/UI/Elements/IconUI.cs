using UnityEngine;
using UnityEngine.UI;

public class IconUI : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private Text iconText;

    public void SetIcon(Sprite iconSprite)
    {
        iconImage.sprite = iconSprite;
    }

    public void SetText(string text)
    {
        iconText.text = text;
    }
}