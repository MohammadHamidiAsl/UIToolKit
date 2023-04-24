using UnityEngine;
using UnityEngine.UI;

public class CircularProgressBarUI : MonoBehaviour
{
    public float fillAmount;

    private Image fillImage;

    void Start()
    {
        fillImage = transform.Find("Fill").GetComponent<Image>();
    }

    void Update()
    {
        fillImage.fillAmount = fillAmount;
    }
}