using UnityEngine;
using UnityEngine.UI;

public class ProgressIndicatorUI : MonoBehaviour
{
    [SerializeField] private Image progressIndicatorImage;
    [Range(0f, 1f)]
    [SerializeField] private float progress = 0.5f;

    private void Start()
    {
        UpdateProgress();
    }

    public void SetProgress(float newProgress)
    {
        progress = Mathf.Clamp01(newProgress);
        UpdateProgress();
    }

    private void UpdateProgress()
    {
        progressIndicatorImage.fillAmount = progress;
    }
}